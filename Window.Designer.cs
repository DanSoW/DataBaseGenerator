
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
			this._txtConnectionString = new System.Windows.Forms.TextBox();
			this._txtQuery = new System.Windows.Forms.TextBox();
			this._btnExecuteQuery = new System.Windows.Forms.Button();
			this._dgvDatabase = new System.Windows.Forms.DataGridView();
			this._tcControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnFindFile = new System.Windows.Forms.Button();
			this._txtNameServer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._dgvDatabase)).BeginInit();
			this._tcControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txtConnectionString
			// 
			this._txtConnectionString.Location = new System.Drawing.Point(12, 173);
			this._txtConnectionString.Name = "_txtConnectionString";
			this._txtConnectionString.Size = new System.Drawing.Size(824, 22);
			this._txtConnectionString.TabIndex = 0;
			// 
			// _txtQuery
			// 
			this._txtQuery.Location = new System.Drawing.Point(12, 201);
			this._txtQuery.Multiline = true;
			this._txtQuery.Name = "_txtQuery";
			this._txtQuery.Size = new System.Drawing.Size(824, 253);
			this._txtQuery.TabIndex = 1;
			// 
			// _btnExecuteQuery
			// 
			this._btnExecuteQuery.Location = new System.Drawing.Point(664, 475);
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
			this._dgvDatabase.Location = new System.Drawing.Point(9, 535);
			this._dgvDatabase.Name = "_dgvDatabase";
			this._dgvDatabase.RowHeadersWidth = 51;
			this._dgvDatabase.RowTemplate.Height = 24;
			this._dgvDatabase.Size = new System.Drawing.Size(824, 301);
			this._dgvDatabase.TabIndex = 3;
			// 
			// _tcControl
			// 
			this._tcControl.Controls.Add(this.tabPage1);
			this._tcControl.Controls.Add(this.tabPage2);
			this._tcControl.Location = new System.Drawing.Point(15, 13);
			this._tcControl.Name = "_tcControl";
			this._tcControl.SelectedIndex = 0;
			this._tcControl.Size = new System.Drawing.Size(821, 151);
			this._tcControl.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this._btnFindFile);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(813, 122);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Локальная база";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.comboBox1);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this._txtNameServer);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(813, 122);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сервер";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(19, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(660, 22);
			this.textBox1.TabIndex = 0;
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
			// _btnFindFile
			// 
			this._btnFindFile.Location = new System.Drawing.Point(716, 63);
			this._btnFindFile.Name = "_btnFindFile";
			this._btnFindFile.Size = new System.Drawing.Size(75, 23);
			this._btnFindFile.TabIndex = 2;
			this._btnFindFile.Text = "...";
			this._btnFindFile.UseVisualStyleBackColor = true;
			// 
			// _txtNameServer
			// 
			this._txtNameServer.Location = new System.Drawing.Point(20, 66);
			this._txtNameServer.Name = "_txtNameServer";
			this._txtNameServer.Size = new System.Drawing.Size(336, 22);
			this._txtNameServer.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя сервера";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(393, 66);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(225, 24);
			this.comboBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(390, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Название базы данных";
			// 
			// _Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 847);
			this.Controls.Add(this._tcControl);
			this.Controls.Add(this._dgvDatabase);
			this.Controls.Add(this._btnExecuteQuery);
			this.Controls.Add(this._txtQuery);
			this.Controls.Add(this._txtConnectionString);
			this.Name = "_Window";
			this.Text = "Database Generator";
			((System.ComponentModel.ISupportInitialize)(this._dgvDatabase)).EndInit();
			this._tcControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _txtConnectionString;
		private System.Windows.Forms.TextBox _txtQuery;
		private System.Windows.Forms.Button _btnExecuteQuery;
		private System.Windows.Forms.DataGridView _dgvDatabase;
		private System.Windows.Forms.TabControl _tcControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button _btnFindFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtNameServer;
	}
}

