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
	public partial class _Window : Form
	{
		public _Window()
		{
			InitializeComponent();
		}

		private void _btnExecuteQuery_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection())
				{
					connection.ConnectionString = _txtConnectionString.Text;
					connection.Open();

					SqlCommand command = new SqlCommand(_txtQuery.Text, connection);
					using (var reader = command.ExecuteReader())
					{
						DataTable table = new DataTable();
						table.Load(reader);
						_dgvDatabase.DataSource = table;
					}
				}
			}
			catch
			{
				MessageBox.Show("Не удалось подключиться к базе данных!",
					"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
