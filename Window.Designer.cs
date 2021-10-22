﻿
namespace DataBaseGenerator
{
	partial class _Window
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._txtQuery = new System.Windows.Forms.TextBox();
			this._btnExecuteQuery = new System.Windows.Forms.Button();
			this._dgvDatabase = new System.Windows.Forms.DataGridView();
			this._tcControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this._btnFindFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._txtFilePath = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this._txtPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this._txtNameUser = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._cmbListDB = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this._txtNameServer = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnGenerateReader = new System.Windows.Forms.Button();
			this.pbReaderGenerator = new System.Windows.Forms.ProgressBar();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this._dgvDatabase)).BeginInit();
			this._tcControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// _txtQuery
			// 
			this._txtQuery.Location = new System.Drawing.Point(6, 6);
			this._txtQuery.Multiline = true;
			this._txtQuery.Name = "_txtQuery";
			this._txtQuery.Size = new System.Drawing.Size(810, 280);
			this._txtQuery.TabIndex = 1;
			// 
			// _btnExecuteQuery
			// 
			this._btnExecuteQuery.Location = new System.Drawing.Point(647, 292);
			this._btnExecuteQuery.Name = "_btnExecuteQuery";
			this._btnExecuteQuery.Size = new System.Drawing.Size(169, 38);
			this._btnExecuteQuery.TabIndex = 2;
			this._btnExecuteQuery.Text = "Выполнить запрос";
			this._btnExecuteQuery.UseVisualStyleBackColor = true;
			this._btnExecuteQuery.Click += new System.EventHandler(this._btnExecuteQuery_Click);
			// 
			// _dgvDatabase
			// 
			this._dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dgvDatabase.Location = new System.Drawing.Point(6, 380);
			this._dgvDatabase.Name = "_dgvDatabase";
			this._dgvDatabase.RowHeadersWidth = 51;
			this._dgvDatabase.RowTemplate.Height = 24;
			this._dgvDatabase.Size = new System.Drawing.Size(810, 250);
			this._dgvDatabase.TabIndex = 3;
			// 
			// _tcControl
			// 
			this._tcControl.Controls.Add(this.tabPage1);
			this._tcControl.Controls.Add(this.tabPage2);
			this._tcControl.Location = new System.Drawing.Point(9, 13);
			this._tcControl.Name = "_tcControl";
			this._tcControl.SelectedIndex = 0;
			this._tcControl.Size = new System.Drawing.Size(830, 151);
			this._tcControl.TabIndex = 4;
			this._tcControl.SelectedIndexChanged += new System.EventHandler(this._tcControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this._btnFindFile);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this._txtFilePath);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(822, 122);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Локальная база";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// _btnFindFile
			// 
			this._btnFindFile.Location = new System.Drawing.Point(716, 63);
			this._btnFindFile.Name = "_btnFindFile";
			this._btnFindFile.Size = new System.Drawing.Size(75, 23);
			this._btnFindFile.TabIndex = 2;
			this._btnFindFile.Text = "...";
			this._btnFindFile.UseVisualStyleBackColor = true;
			this._btnFindFile.Click += new System.EventHandler(this._btnFindFile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Путь к файлу";
			// 
			// _txtFilePath
			// 
			this._txtFilePath.Location = new System.Drawing.Point(19, 64);
			this._txtFilePath.Name = "_txtFilePath";
			this._txtFilePath.Size = new System.Drawing.Size(660, 22);
			this._txtFilePath.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this._txtPassword);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this._txtNameUser);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this._cmbListDB);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this._txtNameServer);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(822, 122);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сервер";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// _txtPassword
			// 
			this._txtPassword.Location = new System.Drawing.Point(217, 83);
			this._txtPassword.Name = "_txtPassword";
			this._txtPassword.PasswordChar = '*';
			this._txtPassword.Size = new System.Drawing.Size(135, 22);
			this._txtPassword.TabIndex = 7;
			this._txtPassword.TextChanged += new System.EventHandler(this._txtPassword_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(217, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Пароль:";
			// 
			// _txtNameUser
			// 
			this._txtNameUser.Location = new System.Drawing.Point(16, 83);
			this._txtNameUser.Name = "_txtNameUser";
			this._txtNameUser.Size = new System.Drawing.Size(135, 22);
			this._txtNameUser.TabIndex = 5;
			this._txtNameUser.TextChanged += new System.EventHandler(this._txtNameUser_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Имя пользователя:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(386, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Название базы данных";
			// 
			// _cmbListDB
			// 
			this._cmbListDB.FormattingEnabled = true;
			this._cmbListDB.Location = new System.Drawing.Point(389, 29);
			this._cmbListDB.Name = "_cmbListDB";
			this._cmbListDB.Size = new System.Drawing.Size(225, 24);
			this._cmbListDB.TabIndex = 2;
			this._cmbListDB.SelectedIndexChanged += new System.EventHandler(this._cmbListDB_SelectedIndexChanged);
			this._cmbListDB.Click += new System.EventHandler(this.comboBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя сервера";
			// 
			// _txtNameServer
			// 
			this._txtNameServer.Location = new System.Drawing.Point(16, 29);
			this._txtNameServer.Name = "_txtNameServer";
			this._txtNameServer.Size = new System.Drawing.Size(336, 22);
			this._txtNameServer.TabIndex = 0;
			this._txtNameServer.TextChanged += new System.EventHandler(this._txtNameServer_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(9, 170);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(830, 665);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this._txtQuery);
			this.tabPage3.Controls.Add(this._btnExecuteQuery);
			this.tabPage3.Controls.Add(this._dgvDatabase);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(822, 636);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Запросы";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnGenerateReader);
			this.tabPage4.Controls.Add(this.pbReaderGenerator);
			this.tabPage4.Controls.Add(this.label6);
			this.tabPage4.Controls.Add(this.numericUpDown1);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(822, 636);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Генератор читателей";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// btnGenerateReader
			// 
			this.btnGenerateReader.Location = new System.Drawing.Point(686, 87);
			this.btnGenerateReader.Name = "btnGenerateReader";
			this.btnGenerateReader.Size = new System.Drawing.Size(130, 37);
			this.btnGenerateReader.TabIndex = 3;
			this.btnGenerateReader.Text = "Запуск";
			this.btnGenerateReader.UseVisualStyleBackColor = true;
			this.btnGenerateReader.Click += new System.EventHandler(this.btnGenerateReader_Click);
			// 
			// pbReaderGenerator
			// 
			this.pbReaderGenerator.Location = new System.Drawing.Point(19, 87);
			this.pbReaderGenerator.Name = "pbReaderGenerator";
			this.pbReaderGenerator.Size = new System.Drawing.Size(645, 37);
			this.pbReaderGenerator.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Количество";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(19, 41);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown1.TabIndex = 0;
			// 
			// _Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 847);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this._tcControl);
			this.Name = "_Window";
			this.Text = "Database Generator";
			((System.ComponentModel.ISupportInitialize)(this._dgvDatabase)).EndInit();
			this._tcControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox _txtQuery;
		private System.Windows.Forms.Button _btnExecuteQuery;
		private System.Windows.Forms.DataGridView _dgvDatabase;
		private System.Windows.Forms.TabControl _tcControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button _btnFindFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txtFilePath;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox _cmbListDB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtNameServer;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox _txtPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _txtNameUser;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnGenerateReader;
		private System.Windows.Forms.ProgressBar pbReaderGenerator;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}

