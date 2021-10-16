using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseGenerator
{
	/// <summary>
	/// Основной класс главного окна
	/// </summary>
	public partial class _Window : Form
	{
		// Строка подключения к базе данных
		private SqlConnectionStringBuilder _sqlConnectionString = new SqlConnectionStringBuilder();

		// Название локального сервера
		// public const string NAME_LOCAL_SERVER = @"(localdb)\MSSQLLocalDB";

		public _Window()
		{
			// Инициализация компонентов на форме
			InitializeComponent();

			// Настройка фильтра
			openFileDialog1.Filter = "Database files(*.mdf)|*.mdf";

			// Установка стандартных данных для строки подключения
			_sqlConnectionString.IntegratedSecurity = true;
			_sqlConnectionString.ConnectTimeout = 2;
		}

		/// <summary>
		/// Выполнение SQL-запроса
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnExecuteQuery_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection())
				{
					connection.ConnectionString = _sqlConnectionString.ToString();
					connection.Open();

					SqlCommand command = new SqlCommand(_txtQuery.Text, connection);
					using (var reader = command.ExecuteReader())
					{
						DataTable table = new DataTable();
						table.Load(reader);
						_dgvDatabase.DataSource = table;

						reader.Close();
					}

					connection.Close();
				}
			}
			catch(Exception error)
			{
				MessageBox.Show("При выполнении операции возникла ошибка! \n" + error.Message,
					"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Открытие файла базы данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnFindFile_Click(object sender, EventArgs e)
		{
			// Отображение OpenFileDialog для выбора файла 
			if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
			{
				_sqlConnectionString.AttachDBFilename = @"";
				_sqlConnectionString.DataSource = @"";
				return;
			}

			_txtFilePath.Text = openFileDialog1.FileName;
			_sqlConnectionString.DataSource = @"(localdb)\MSSQLLocalDB";
			_sqlConnectionString.AttachDBFilename = openFileDialog1.FileName;
		}

		/// <summary>
		/// Получение списка баз данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox1_Click(object sender, EventArgs e)
		{
			_cmbListDB.Items.Clear();
			try
			{
				using (SqlConnection connection = new SqlConnection())
				{
					connection.ConnectionString = _sqlConnectionString.ToString();
					connection.Open();

					using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", connection))
					{
						using (IDataReader dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								_cmbListDB.Items.Add(dr[0].ToString());
							}

							dr.Close();
						}
					}

					connection.Close();
				}
			}
			catch (Exception error)
			{
				MessageBox.Show("При выполнении операции возникла ошибка! \n" + error.Message,
					"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _tcControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			_sqlConnectionString.AttachDBFilename = @"";
			_sqlConnectionString.DataSource = @"";
			_sqlConnectionString.InitialCatalog = @"";
			_sqlConnectionString.Password = @"";
			_sqlConnectionString.UserID = @"";

			_txtNameServer.Text = "";
			_cmbListDB.Items.Clear();
			_txtFilePath.Text = "";
		}

		private void _txtNameServer_TextChanged(object sender, EventArgs e)
		{
			_sqlConnectionString.DataSource = @_txtNameServer.Text;
		}

		private void _cmbListDB_SelectedIndexChanged(object sender, EventArgs e)
		{
			_sqlConnectionString.InitialCatalog = _cmbListDB.SelectedItem.ToString();
		}

		private void _txtPassword_TextChanged(object sender, EventArgs e)
		{
			_sqlConnectionString.Password = @_txtPassword.Text;
		}

		private void _txtNameUser_TextChanged(object sender, EventArgs e)
		{
			_sqlConnectionString.UserID = @_txtNameUser.Text;
		}
	}
}
