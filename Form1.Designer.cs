namespace IISLogsToSQLite {
	partial class FormMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.FileLocationTextBox = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FromCustomRadio = new System.Windows.Forms.RadioButton();
			this.FromDirExtRadio = new System.Windows.Forms.RadioButton();
			this.FromDirRadio = new System.Windows.Forms.RadioButton();
			this.FromFileRadio = new System.Windows.Forms.RadioButton();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.labelFrom = new System.Windows.Forms.Label();
			this.linkLabelContact = new System.Windows.Forms.LinkLabel();
			this.buttonProcess = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonCreateDb = new System.Windows.Forms.Button();
			this.labelTableName = new System.Windows.Forms.Label();
			this.textBoxTableName = new System.Windows.Forms.TextBox();
			this.textBoxDatabase = new System.Windows.Forms.TextBox();
			this.buttonSelectDb = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(12, 16);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
			this.SelectFileButton.TabIndex = 0;
			this.SelectFileButton.Text = "Select a file";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// FileLocationTextBox
			// 
			this.FileLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.FileLocationTextBox.Enabled = false;
			this.FileLocationTextBox.Location = new System.Drawing.Point(93, 16);
			this.FileLocationTextBox.Multiline = true;
			this.FileLocationTextBox.Name = "FileLocationTextBox";
			this.FileLocationTextBox.Size = new System.Drawing.Size(434, 44);
			this.FileLocationTextBox.TabIndex = 1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FromCustomRadio);
			this.groupBox1.Controls.Add(this.FromDirExtRadio);
			this.groupBox1.Controls.Add(this.FromDirRadio);
			this.groupBox1.Controls.Add(this.FromFileRadio);
			this.groupBox1.Location = new System.Drawing.Point(12, 66);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(186, 112);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File options";
			// 
			// FromCustomRadio
			// 
			this.FromCustomRadio.AutoSize = true;
			this.FromCustomRadio.Location = new System.Drawing.Point(6, 88);
			this.FromCustomRadio.Name = "FromCustomRadio";
			this.FromCustomRadio.Size = new System.Drawing.Size(60, 17);
			this.FromCustomRadio.TabIndex = 3;
			this.FromCustomRadio.TabStop = true;
			this.FromCustomRadio.Text = "Custom";
			this.FromCustomRadio.UseVisualStyleBackColor = true;
			this.FromCustomRadio.CheckedChanged += new System.EventHandler(this.FromCustomRadio_CheckedChanged);
			// 
			// FromDirExtRadio
			// 
			this.FromDirExtRadio.AutoSize = true;
			this.FromDirExtRadio.Location = new System.Drawing.Point(6, 42);
			this.FromDirExtRadio.Name = "FromDirExtRadio";
			this.FromDirExtRadio.Size = new System.Drawing.Size(175, 17);
			this.FromDirExtRadio.TabIndex = 2;
			this.FromDirExtRadio.TabStop = true;
			this.FromDirExtRadio.Text = "Use this directory and extension";
			this.FromDirExtRadio.UseVisualStyleBackColor = true;
			this.FromDirExtRadio.CheckedChanged += new System.EventHandler(this.FromRadioChanged);
			// 
			// FromDirRadio
			// 
			this.FromDirRadio.AutoSize = true;
			this.FromDirRadio.Location = new System.Drawing.Point(6, 65);
			this.FromDirRadio.Name = "FromDirRadio";
			this.FromDirRadio.Size = new System.Drawing.Size(106, 17);
			this.FromDirRadio.TabIndex = 1;
			this.FromDirRadio.TabStop = true;
			this.FromDirRadio.Text = "Use this directory";
			this.FromDirRadio.UseVisualStyleBackColor = true;
			this.FromDirRadio.CheckedChanged += new System.EventHandler(this.FromRadioChanged);
			// 
			// FromFileRadio
			// 
			this.FromFileRadio.AutoSize = true;
			this.FromFileRadio.Location = new System.Drawing.Point(6, 19);
			this.FromFileRadio.Name = "FromFileRadio";
			this.FromFileRadio.Size = new System.Drawing.Size(79, 17);
			this.FromFileRadio.TabIndex = 0;
			this.FromFileRadio.TabStop = true;
			this.FromFileRadio.Text = "Use this file";
			this.FromFileRadio.UseVisualStyleBackColor = true;
			this.FromFileRadio.CheckedChanged += new System.EventHandler(this.FromRadioChanged);
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFrom.Enabled = false;
			this.textBoxFrom.Location = new System.Drawing.Point(204, 85);
			this.textBoxFrom.Multiline = true;
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(323, 63);
			this.textBoxFrom.TabIndex = 3;
			// 
			// labelFrom
			// 
			this.labelFrom.AutoSize = true;
			this.labelFrom.Location = new System.Drawing.Point(201, 69);
			this.labelFrom.Name = "labelFrom";
			this.labelFrom.Size = new System.Drawing.Size(78, 13);
			this.labelFrom.TabIndex = 4;
			this.labelFrom.Text = "Will select from";
			// 
			// linkLabelContact
			// 
			this.linkLabelContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabelContact.AutoSize = true;
			this.linkLabelContact.Location = new System.Drawing.Point(412, 0);
			this.linkLabelContact.Name = "linkLabelContact";
			this.linkLabelContact.Size = new System.Drawing.Size(127, 13);
			this.linkLabelContact.TabIndex = 5;
			this.linkLabelContact.TabStop = true;
			this.linkLabelContact.Text = "Created by James Skemp";
			this.linkLabelContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContact_LinkClicked);
			// 
			// buttonProcess
			// 
			this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonProcess.Location = new System.Drawing.Point(374, 267);
			this.buttonProcess.Name = "buttonProcess";
			this.buttonProcess.Size = new System.Drawing.Size(153, 23);
			this.buttonProcess.TabIndex = 6;
			this.buttonProcess.Text = "Process";
			this.buttonProcess.UseVisualStyleBackColor = true;
			this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 295);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(539, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(524, 17);
			this.toolStripStatusLabel1.Spring = true;
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 296);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(515, 0);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.buttonCreateDb);
			this.groupBox2.Controls.Add(this.labelTableName);
			this.groupBox2.Controls.Add(this.textBoxTableName);
			this.groupBox2.Controls.Add(this.textBoxDatabase);
			this.groupBox2.Controls.Add(this.buttonSelectDb);
			this.groupBox2.Location = new System.Drawing.Point(18, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(509, 77);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Database";
			// 
			// buttonCreateDb
			// 
			this.buttonCreateDb.Location = new System.Drawing.Point(66, 19);
			this.buttonCreateDb.Name = "buttonCreateDb";
			this.buttonCreateDb.Size = new System.Drawing.Size(50, 23);
			this.buttonCreateDb.TabIndex = 15;
			this.buttonCreateDb.Text = "Create";
			this.buttonCreateDb.UseVisualStyleBackColor = true;
			this.buttonCreateDb.Click += new System.EventHandler(this.buttonCreateDb_Click);
			// 
			// labelTableName
			// 
			this.labelTableName.AutoSize = true;
			this.labelTableName.Location = new System.Drawing.Point(53, 50);
			this.labelTableName.Name = "labelTableName";
			this.labelTableName.Size = new System.Drawing.Size(63, 13);
			this.labelTableName.TabIndex = 14;
			this.labelTableName.Text = "Table name";
			// 
			// textBoxTableName
			// 
			this.textBoxTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTableName.Location = new System.Drawing.Point(122, 47);
			this.textBoxTableName.Name = "textBoxTableName";
			this.textBoxTableName.Size = new System.Drawing.Size(381, 20);
			this.textBoxTableName.TabIndex = 13;
			// 
			// textBoxDatabase
			// 
			this.textBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDatabase.Location = new System.Drawing.Point(122, 21);
			this.textBoxDatabase.Name = "textBoxDatabase";
			this.textBoxDatabase.Size = new System.Drawing.Size(381, 20);
			this.textBoxDatabase.TabIndex = 12;
			// 
			// buttonSelectDb
			// 
			this.buttonSelectDb.Location = new System.Drawing.Point(10, 19);
			this.buttonSelectDb.Name = "buttonSelectDb";
			this.buttonSelectDb.Size = new System.Drawing.Size(50, 23);
			this.buttonSelectDb.TabIndex = 11;
			this.buttonSelectDb.Text = "Select";
			this.buttonSelectDb.UseVisualStyleBackColor = true;
			this.buttonSelectDb.Click += new System.EventHandler(this.buttonSelectDb_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 317);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.buttonProcess);
			this.Controls.Add(this.linkLabelContact);
			this.Controls.Add(this.labelFrom);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.FileLocationTextBox);
			this.Controls.Add(this.SelectFileButton);
			this.MinimumSize = new System.Drawing.Size(555, 353);
			this.Name = "FormMain";
			this.Text = "IIS Logs to SQLite BETA";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.TextBox FileLocationTextBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton FromDirExtRadio;
		private System.Windows.Forms.RadioButton FromDirRadio;
		private System.Windows.Forms.RadioButton FromFileRadio;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.Label labelFrom;
		private System.Windows.Forms.RadioButton FromCustomRadio;
		private System.Windows.Forms.LinkLabel linkLabelContact;
		private System.Windows.Forms.Button buttonProcess;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelTableName;
		private System.Windows.Forms.TextBox textBoxTableName;
		private System.Windows.Forms.TextBox textBoxDatabase;
		private System.Windows.Forms.Button buttonSelectDb;
		private System.Windows.Forms.Button buttonCreateDb;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

