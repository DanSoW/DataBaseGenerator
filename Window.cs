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
using Bogus;
using Bogus.DataSets;

namespace DataBaseGenerator
{
	/// <summary>
	/// Основной класс главного окна
	/// </summary>
	public partial class _Window : Form
	{
		/// <summary>
		/// Структура под промежуток
		/// </summary>
		struct Range
		{
			public double min;
			public double max;

			public bool CheckContains(double value)
			{
				return min <= value && value <= max;
			}
		}

		// Строка подключения к базе данных
		private SqlConnectionStringBuilder _sqlConnectionString = new SqlConnectionStringBuilder();

		// Название локального сервера
		// public const string NAME_LOCAL_SERVER = @"(localdb)\MSSQLLocalDB";
		public const string LOCAL_DATABASE = 
			@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		
		public const string LOCAL_DATABASE_GENERATOR =
			@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GeneratorData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		// [1; 3000] - диапазон данных, которые будут взяты из БД
		public const int MIN_SIZE = 1;
		public const int MAX_SIZE = 90000;

		// Максимальная величина выборки данных для генерации
		public const int MAX_LENGHT_SAMPLE			= 10000;

		// Мужские имена по-умолчанию
		public List<string> DEFAULT_MALE_NAMES		= new List<string>{ "Михаил", "Максим", "Артём" };

		// Женские имена по-умолчанию
		public List<string> DEFAULT_FEMALE_NAMES	= new List<string>{ "Мария", "Анна", "Лариса" };

		// Названия жанров по-умолчанию
		public List<string> DEFAULT_GENRE_NAMES = new List<string> {
			"Фантастика", "Детектив", "Роман",
			"Классика", "Триллер", "Поэзия"
		};

		// ID жанров в текущей базе данных соответствующие определённым названиям по-умолчанию
		public Dictionary<string, int> DEFAULT_GENRE_ID = new Dictionary<string, int>
		{
			["Фантастика"] = 8,
			["Детектив"] = 9,
			["Роман"] = 10,
			["Классика"] = 11,
			["Триллер"] = 12,
			["Поэзия"] = 13
		};

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
			catch (Exception error)
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
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
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

		private SqlConnection GetConnection(string connect)
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connect;

			return connection;
		}

		private Dictionary<string, Range> getNamesProbability(Dictionary<string, TrackBar> names)
		{
			int totalNames = names.Values.Sum(tb => tb.Value);

			Dictionary<string, Range> namesProbablity = new Dictionary<string, Range>();
			double previousProbabilty = 0;

			foreach (var item in names)
			{
				double k = (double)names[item.Key].Value / totalNames;
				if (k > 0)
				{
					namesProbablity[item.Key] = new Range
					{
						min = previousProbabilty,
						max = previousProbabilty + k
					};

					previousProbabilty += k;
				}
			}

			return namesProbablity;
		}

		private void btnGenerateReader_Click(object sender, EventArgs e)
		{
			_pbReaderGenerator.Value = 0;
			_pbReaderGenerator.Maximum = (int)_nudCountReaders.Value;

			Random rnd = new Random();

			// Подключение библиотеки Faker для генерации произвольных данных
			var faker = new Faker("ru");

			using (var connection = GetConnection(LOCAL_DATABASE))
			{
				connection.Open();

				Dictionary<string, Range> namesProbablityMale = getNamesProbability(new Dictionary<string, TrackBar>
				{
					["Михаил"]	= _tbNameMichael,
					["Максим"]	= _tbNameMaxim,
					["Артем"]	= _tbNameArtem,
				});

				Dictionary<string, Range> namesProbablityFemale = getNamesProbability(new Dictionary<string, TrackBar>
				{
					["Мария"]	= _tbNameMaria,
					["Анна"]	= _tbNameAnna,
					["Лариса"]	= _tbNameLarisa,
				});

				for (var i = 0; i < _nudCountReaders.Value; i++)
				{
					var isMale = ((double)_tbMaleFemale.Value / MAX_LENGHT_SAMPLE) < rnd.NextDouble();
					var gender = isMale ? true : false;

					Dictionary<string, Range> namesProbablity = (gender) ? namesProbablityMale : namesProbablityFemale;

					string name = null;
					var k = rnd.NextDouble();

					foreach(var item in namesProbablity)
					{
						if (item.Value.CheckContains(k))
						{
							name = item.Key;
							break;
						}
					}

					if(name == null)
					{
						name = faker.Name.FullName((gender)? 
							Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female);
					}
					else
					{
						if(gender)
						{
							name += " " + faker.Name.LastName(Bogus.DataSets.Name.Gender.Male);
						}
						else
						{
							name += " " + faker.Name.LastName(Bogus.DataSets.Name.Gender.Female);
						}
					}

					SqlCommand command = new SqlCommand(
						"INSERT INTO readers VALUES(@password_data, @full_name, @home_address)", 
						connection);

					command.Parameters.AddWithValue("@password_data", faker.Random.String2(10, "1234567890"));
					command.Parameters.AddWithValue("@full_name", @name);
					command.Parameters.AddWithValue("@home_address", @faker.Address.StreetAddress());
					command.ExecuteNonQuery();

					_pbReaderGenerator.Value++;
				}

				connection.Close();
			}
		}

		private void _tbNameMichael_ValueChanged(object sender, EventArgs e)
		{
			_lCountMichael.Text = _tbNameMichael.Value.ToString();
		}

		private void _tbNameMaxim_ValueChanged(object sender, EventArgs e)
		{
			_lCountMaxim.Text = _tbNameMaxim.Value.ToString();
		}

		private void _tbNameArtem_ValueChanged(object sender, EventArgs e)
		{
			_lCountArtem.Text = _tbNameArtem.Value.ToString();
		}

		private void _tbNameMaria_ValueChanged(object sender, EventArgs e)
		{
			_lCountMaria.Text = _tbNameMaria.Value.ToString();
		}

		private void _tbNameAnna_ValueChanged(object sender, EventArgs e)
		{
			_lCountAnna.Text = _tbNameAnna.Value.ToString();
		}

		private void _tbNameLarisa_ValueChanged(object sender, EventArgs e)
		{
			_lCountLarisa.Text = _tbNameLarisa.Value.ToString();
		}

		private void _tbMaleFemale_ValueChanged(object sender, EventArgs e)
		{
			int value = _tbMaleFemale.Value;
			_lCountManWomen.Text = (MAX_LENGHT_SAMPLE - value).ToString() + "/" + value.ToString();
		}

		private void _tbCountPagesFrom_ValueChanged(object sender, EventArgs e)
		{
			_lCountPagesFrom.Text = _tbCountPagesFrom.Value.ToString();
		}

		private void _tbCountPagesTo_ValueChanged(object sender, EventArgs e)
		{
			_lCountPagesTo.Text = _tbCountPagesTo.Value.ToString();
		}

		private void _tbGenreFantasy_ValueChanged(object sender, EventArgs e)
		{
			_lCountFantasy.Text = _tbGenreFantasy.Value.ToString();
		}

		private void _tbGenreDetective_ValueChanged(object sender, EventArgs e)
		{
			_lCountDetective.Text = _tbGenreDetective.Value.ToString();
		}

		private void _tbGenreNovel_ValueChanged(object sender, EventArgs e)
		{
			_lCountNovel.Text = _tbGenreNovel.Value.ToString();
		}

		private void _tbGenreClassic_ValueChanged(object sender, EventArgs e)
		{
			_lCountClassic.Text = _tbGenreClassic.Value.ToString();
		}

		private void _tbGenreThriller_ValueChanged(object sender, EventArgs e)
		{
			_lCountThriller.Text = _tbGenreThriller.Value.ToString();
		}

		private void _tbGenrePoetry_ValueChanged(object sender, EventArgs e)
		{
			_lCountPoetry.Text = _tbGenrePoetry.Value.ToString();
		}

		private void _btnGenerateBook_Click(object sender, EventArgs e)
		{
			_pbBookGenerator.Value = 0;
			_pbBookGenerator.Maximum = (int)_nudCountBooks.Value;

			Random rnd = new Random();

			// Подключение библиотеки Faker для генерации произвольных данных
			var faker = new Faker("ru");

			using (var connection = GetConnection(LOCAL_DATABASE))
			{
				connection.Open();

				Dictionary<string, Range> namesGenre = getNamesProbability(new Dictionary<string, TrackBar>
				{
					["Фантастика"] = _tbNameMichael,
					["Детектив"] = _tbNameMaxim,
					["Роман"] = _tbNameArtem,
					["Классика"] = _tbGenreClassic,
					["Триллер"] = _tbGenreThriller,
					["Поэзия"] = _tbGenrePoetry
				});

				for (var i = 0; i < _nudCountBooks.Value; i++)
				{
					string name = null;
					var k = rnd.NextDouble();

					foreach (var item in namesGenre)
					{
						if (item.Value.CheckContains(k))
						{
							name = item.Key;
							break;
						}
					}

					if (name == null)
					{
						int index = rnd.Next(0, (DEFAULT_GENRE_NAMES.Count - 1));
						name = DEFAULT_GENRE_NAMES[index];
					}

					SqlCommand command = new SqlCommand(
						"INSERT INTO books VALUES(@register_num, @count_pages, @year_publish, @genres_id)",
						connection);

					MessageBox.Show(@DEFAULT_GENRE_ID[name].ToString());

					command.Parameters.AddWithValue("@register_num", faker.Random.String2(10, "1234567890"));
					command.Parameters.AddWithValue("@genres_id", @DEFAULT_GENRE_ID[name].ToString());
					command.Parameters.AddWithValue("@year_publish", @faker.Random.Number(1800, 2021).ToString());
					command.Parameters.AddWithValue("@count_pages",
						@faker.Random.Number(_tbCountPagesFrom.Value, _tbCountPagesTo.Value).ToString());
					command.ExecuteNonQuery();

					_pbReaderGenerator.Value++;
				}

				connection.Close();
			}
		}
	}
}
