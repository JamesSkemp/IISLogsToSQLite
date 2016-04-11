using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSUtil;
using System.Data.SQLite;
using System.IO;

namespace IISLogsToSQLite {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();
		}

		private void SelectFileButton_Click(object sender, EventArgs e) {
			openFileDialog1.FileName = "";
			openFileDialog1.Multiselect = false;
			openFileDialog1.Title = "Select an example file to parse.";
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				FileLocationTextBox.Text = openFileDialog1.FileName;

				if (FromFileRadio.Checked) {
					textBoxFrom.Text = openFileDialog1.FileName;
				} else if (FromDirExtRadio.Checked) {
					textBoxFrom.Text = Path.GetDirectoryName(openFileDialog1.FileName) + Path.DirectorySeparatorChar.ToString() + "*" + Path.GetExtension(openFileDialog1.FileName);
				} else if (FromDirRadio.Checked) {
					textBoxFrom.Text = Path.GetDirectoryName(openFileDialog1.FileName) + Path.DirectorySeparatorChar.ToString() + "*.*";
				}

			}


		}

		private void FromRadioChanged(object sender, EventArgs e) {
			if (FileLocationTextBox.Text != "") {
				if (FromFileRadio.Checked) {
					textBoxFrom.Text = FileLocationTextBox.Text;
				} else if (FromDirExtRadio.Checked) {
					textBoxFrom.Text = Path.GetDirectoryName(FileLocationTextBox.Text) + Path.DirectorySeparatorChar.ToString() + "*" + Path.GetExtension(FileLocationTextBox.Text);
				} else if (FromDirRadio.Checked) {
					textBoxFrom.Text = Path.GetDirectoryName(FileLocationTextBox.Text) + Path.DirectorySeparatorChar.ToString() + "*.*";
				}
			}
		}

		private void FromCustomRadio_CheckedChanged(object sender, EventArgs e) {
			if (FromCustomRadio.Checked) {
				textBoxFrom.Enabled = true;
			} else {
				textBoxFrom.Enabled = false;
				FromRadioChanged(sender, e);
			}
		}

		private void linkLabelContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://jamesrskemp.com/apps/IISLogsToSQLite/?0.1");
		}

		private void buttonSelectDb_Click(object sender, EventArgs e) {
			openFileDialog1.FileName = "";
			openFileDialog1.Multiselect = false;
			openFileDialog1.Title = "Select database to use.";
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBoxDatabase.Text = openFileDialog1.FileName;
			}
		}

		private void buttonCreateDb_Click(object sender, EventArgs e) {
			saveFileDialog1.FileName = "";
			saveFileDialog1.Title = "Select where to create a database.";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
				textBoxDatabase.Text = saveFileDialog1.FileName;
			}
		}

		private void buttonProcess_Click(object sender, EventArgs e) {
			buttonProcess.Enabled = false;
			if (textBoxFrom.Text.Trim() == "") {
				MessageBox.Show("You must select where to process logs from.");
			} else if (textBoxDatabase.Text.Trim() == "") {
				MessageBox.Show("You must select a database to open, or the name of the database to create.");
			} else if (textBoxTableName.Text.Trim() == "") {
				MessageBox.Show("You must enter a table name to store the data into.");
			} else {
				// Process logs.
				DataTable table = GetDataFromLogs();
				if (table.Rows.Count > 0) {
					SaveDataToDatabase(table);
				}
				table.Dispose();
			}
			buttonProcess.Enabled = true;
		}

		private DataTable GetDataFromLogs() {
			DataTable dataResults = new DataTable();

			LogQueryClass LogParser = new LogQueryClass();

			ILogRecordset rs = LogParser.Execute("SELECT * FROM '" + textBoxFrom.Text.Trim() + "'", new COMIISW3CInputContextClass());

			for (int i = 0; i < rs.getColumnCount(); i++) {
				if (!dataResults.Columns.Contains(rs.getColumnName(i))) {
					dataResults.Columns.Add(rs.getColumnName(i));
				}
			}

			//dataGridView1.DataSource = dataResults.DefaultView;

			ILogRecord rcd;

			DataRow row;

			while (!rs.atEnd()) {
				row = dataResults.NewRow();
			    rcd = rs.getRecord();
				for (int i = 0; i < rs.getColumnCount(); i++) {
					row[rs.getColumnName(i)] = rcd.getValue(rs.getColumnName(i));
				}
				dataResults.Rows.Add(row);

				rs.moveNext();
			}
			rs.close();

			return dataResults;
		}

		private bool SaveDataToDatabase(DataTable dataResults) {
			try {
				SQLiteConnection connection = new SQLiteConnection();

				connection.ConnectionString = "Data Source=" + textBoxDatabase.Text;
				connection.Open();

				SQLiteCommand command = new SQLiteCommand();
				command.Connection = connection;
				command.CommandType = CommandType.Text;

				using (SQLiteTransaction transaction = connection.BeginTransaction()) {
					StringBuilder createStatement = new StringBuilder();

					createStatement.Append("CREATE TABLE IF NOT EXISTS " + textBoxTableName.Text + " (id INTEGER PRIMARY KEY");

					for (int i = 0; i < dataResults.Columns.Count; i++) {
						createStatement.Append(", ");
						createStatement.Append("[" + dataResults.Columns[i].ColumnName + "]");
					}

					createStatement.Append(")");

					command.CommandText = createStatement.ToString();

					command.ExecuteNonQuery();

					transaction.Commit();
				}

				using (SQLiteTransaction transaction = connection.BeginTransaction()) {
					StringBuilder insertStatement = new StringBuilder();

					insertStatement.Append("INSERT INTO " + textBoxTableName.Text + " (");

					for (int i = 0; i < dataResults.Columns.Count; i++) {
						if (i > 0) {
							insertStatement.Append(", ");
						}
						insertStatement.Append("[" + dataResults.Columns[i].ColumnName + "]");
						command.Parameters.Add(new SQLiteParameter("param" + dataResults.Columns[i].ColumnName));
					}

					insertStatement.Append(") VALUES (");

					for (int i = 0; i < dataResults.Columns.Count; i++) {
						if (i > 0) {
							insertStatement.Append(", ");
						}
						insertStatement.Append("?");
					}

					insertStatement.Append(")");

					command.CommandText = insertStatement.ToString();

					foreach (DataRow row in dataResults.Rows) {
						try {
							for (int i = 0; i < dataResults.Columns.Count; i++) {
								command.Parameters["param" + dataResults.Columns[i].ColumnName].Value = row[dataResults.Columns[i].ColumnName].ToString();
							}
						} catch { }
						command.ExecuteNonQuery();
					}

					transaction.Commit();

				}

				command.Dispose();

				connection.Close();
				connection.Dispose();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				MessageBox.Show(ex.StackTrace);
			}

			return true;
		}

	}
}
