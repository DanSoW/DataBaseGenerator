using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

		CancellationTokenSource _readerGeneratorCancellationToken = null;
		CancellationTokenSource _bookGeneratorCancellationToken = null;

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

		private void GenerateReaders(SqlConnection connection, 
			Dictionary<string, Range> namesProbablityMale,
			Dictionary<string, Range> namesProbablityFemale,
			int count,
			int maleFemale,
			bool checkedTransaction,
			IProgress<ProgressInfo> progress,
			CancellationTokenSource cancellationToken)
		{
			Random rnd = new Random();

			// Подключение библиотеки Faker для генерации произвольных данных
			var faker = new Faker("ru");

			using (connection)
			{
				connection.Open();
				var transaction = checkedTransaction ? connection.BeginTransaction() : null;

				for (var i = 0; i < count; i++)
				{
					var isMale = ((double)maleFemale / MAX_LENGHT_SAMPLE) < rnd.NextDouble();
					var gender = isMale ? true : false;

					Dictionary<string, Range> namesProbablity = (gender) ? namesProbablityMale : namesProbablityFemale;

					string name = null;
					var k = rnd.NextDouble();

					foreach (var item in namesProbablity)
					{
						if (item.Value.CheckContains(k))
						{
							name = item.Key;
							break;
						}
					}

					if (name == null)
					{
						name = faker.Name.FullName((gender) ?
							Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female);
					}
					else
					{
						if (gender)
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

					if(transaction != null)
					{
						command.Transaction = transaction;
					}

					command.ExecuteNonQuery();

					command = new SqlCommand("SELECT count(*) FROM readers", connection);

					if (transaction != null)
					{
						command.Transaction = transaction;
					}

					var info = (transaction != null) ? $"Читателей в транзакции: {command.ExecuteScalar()}"
						: $"Количество читателей: {command.ExecuteScalar()}";

					progress?.Report(new ProgressInfo
					{
						value = i + 1,
						info = info
					});

					if (cancellationToken.IsCancellationRequested)
					{
						return;
					}

					Thread.Sleep(50);
				}

				transaction?.Commit();
				connection.Close();
			}
		}

		private async void btnGenerateReader_Click(object sender, EventArgs e)
		{
			if (_readerGeneratorCancellationToken != null)
			{
				_readerGeneratorCancellationToken.Cancel();
				return;
			}

			_readerGeneratorCancellationToken = new CancellationTokenSource();

			var connection = GetConnection(LOCAL_DATABASE);
			_pbReaderGenerator.Value = 0;
			_pbReaderGenerator.Maximum = (int)_nudCountReaders.Value;

			Dictionary<string, Range> namesProbablityMale = getNamesProbability(new Dictionary<string, TrackBar>
			{
				["Михаил"] = _tbNameMichael,
				["Максим"] = _tbNameMaxim,
				["Артем"] = _tbNameArtem,
			});

			Dictionary<string, Range> namesProbablityFemale = getNamesProbability(new Dictionary<string, TrackBar>
			{
				["Мария"] = _tbNameMaria,
				["Анна"] = _tbNameAnna,
				["Лариса"] = _tbNameLarisa,
			});

			/*var progress = new Progress<int>(value =>
			{
				_pbReaderGenerator.Value = value;
			});*/

			var progress = new Progress<ProgressInfo>(prog =>
			{
				_pbReaderGenerator.Value = prog.value;
				_lblRealReaderCounts.Text = prog.info;
			});

			var count = (int)_nudCountReaders.Value;
			var maleFemale = _tbMaleFemale.Value;
			var checkedTransaction = _cbReaderToTransact.Checked;

			_btnGenerateReader.Text = "Отмена";
			_cbReaderToTransact.Enabled = false;

			await Task.Run(() =>
			{
				GenerateReaders(connection, namesProbablityMale,
					namesProbablityFemale, count,
					maleFemale, checkedTransaction, progress,
					_readerGeneratorCancellationToken);
			});

			_btnGenerateReader.Text = "Запустить";
			_lblRealReaderCounts.Text = "";
			_readerGeneratorCancellationToken.Dispose();
			_readerGeneratorCancellationToken = null;
			_cbReaderToTransact.Enabled = true;
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

		private void GenerateBooks(
			SqlConnection connection,
			Dictionary<string, Range> namesGenre,
			int count,
			bool checkedTransact,
			int countPagesFrom,
			int countPagesTo,
			IProgress<ProgressInfo> progress,
			CancellationTokenSource cancellationToken)
		{
			Random rnd = new Random();

			// Подключение библиотеки Faker для генерации произвольных данных
			var faker = new Faker("ru");

			using (connection)
			{
				connection.Open();
				var transaction = checkedTransact ? connection.BeginTransaction() : null;

				for (var i = 0; i < count; i++)
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
						"INSERT INTO books VALUES(@genres_id, @register_num, @count_pages, @year_publish)",
						connection);

					command.Parameters.AddWithValue("@genres_id", @DEFAULT_GENRE_ID[name].ToString());
					command.Parameters.AddWithValue("@register_num", faker.Random.String2(10, "1234567890"));
					command.Parameters.AddWithValue("@count_pages",
						@faker.Random.Number(countPagesFrom, countPagesTo).ToString());
					command.Parameters.AddWithValue("@year_publish", @faker.Random.Number(1800, 2021).ToString());

					if(transaction != null)
					{
						command.Transaction = transaction;
					}

					command.ExecuteNonQuery();

					// progress?.Report(i + 1);

					command = new SqlCommand("SELECT count(*) FROM books", connection);

					if (transaction != null)
					{
						command.Transaction = transaction;
					}

					var info = (transaction != null) ? $"Книг в транзакции: {command.ExecuteScalar()}"
						: $"Количество книг: {command.ExecuteScalar()}";

					progress?.Report(new ProgressInfo
					{
						value = i + 1,
						info = info
					});

					if (cancellationToken.IsCancellationRequested)
					{
						return;
					}

					Thread.Sleep(50);
				}

				transaction?.Commit();
				connection.Close();
			}
		}

		private async void _btnGenerateBook_Click(object sender, EventArgs e)
		{
			if (_bookGeneratorCancellationToken != null)
			{
				_bookGeneratorCancellationToken.Cancel();
				return;
			}

			_bookGeneratorCancellationToken = new CancellationTokenSource();

			var connection = GetConnection(LOCAL_DATABASE);

			_pbBookGenerator.Value = 0;
			_pbBookGenerator.Maximum = (int)_nudCountBooks.Value;

			Dictionary<string, Range> namesGenre = getNamesProbability(new Dictionary<string, TrackBar>
			{
				["Фантастика"] = _tbNameMichael,
				["Детектив"] = _tbNameMaxim,
				["Роман"] = _tbNameArtem,
				["Классика"] = _tbGenreClassic,
				["Триллер"] = _tbGenreThriller,
				["Поэзия"] = _tbGenrePoetry
			});

			var count = (int)_nudCountBooks.Value;
			var countPagesFrom = _tbCountPagesFrom.Value;
			var countPagesTo = _tbCountPagesTo.Value;
			var checkedTransact = _cbBooksToTransact.Checked;

			/*var progress = new Progress<int>(value =>
			{
				_pbBookGenerator.Value = value;
			});*/

			var progress = new Progress<ProgressInfo>(prog =>
			{
				_pbBookGenerator.Value = prog.value;
				_lbRealBooksCount.Text = prog.info;
			});

			_btnGenerateBook.Text = "Отмена";
			_cbBooksToTransact.Enabled = false;

			await Task.Run(() =>
			{
				GenerateBooks(
					connection,
					namesGenre,
					count, checkedTransact, countPagesFrom,
					countPagesTo, progress,
					_bookGeneratorCancellationToken);
			});

			_btnGenerateBook.Text = "Запустить";
			_bookGeneratorCancellationToken.Dispose();
			_bookGeneratorCancellationToken = null;
			_cbBooksToTransact.Enabled = true;
		}

		private Statistics GetStatistics(SqlConnection connection)
		{
			var statistics = new Statistics();

			try
			{
				using (connection)
				{
					connection.Open();

					var command = new SqlCommand("SELECT count(*) FROM books", connection);
					statistics.booksCount = (int)command.ExecuteScalar();

					command = new SqlCommand("SELECT books.genres_id, genres.title, count(*) as count FROM books" +
							" INNER JOIN genres ON books.genres_id = genres.id GROUP BY books.genres_id, genres.title", connection);

					statistics.booksCountByGenre = new Dictionary<string, int>();

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							statistics.booksCountByGenre[reader.GetString(1)] = reader.GetInt32(2);
						}
					}

					command = new SqlCommand("SELECT count(*) FROM readers", connection);
					statistics.readersCount = (int)command.ExecuteScalar();

					command = new SqlCommand("SELECT 'Михаил' as name, SUM(count) as count FROM (SELECT (SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE (SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						"= 'Михаил' GROUP BY full_name) AS T " +
						"UNION SELECT 'Максим' as name, SUM(count) as count FROM(SELECT(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						" = 'Максим' GROUP BY full_name) AS T UNION SELECT 'Артём' as name, SUM(count) as count FROM(SELECT(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						"= 'Артём' GROUP BY full_name) AS T UNION SELECT 'Мария' as name, SUM(count) as count FROM(SELECT(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						"= 'Мария' GROUP BY full_name) AS T UNION SELECT 'Анна' as name, SUM(count) as count FROM(SELECT(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						"= 'Анна' GROUP BY full_name) AS T UNION SELECT 'Лариса' as name, SUM(count) as count FROM(SELECT(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) as fname, count(*) as count FROM readers WHERE(SELECT TOP 1 value FROM STRING_SPLIT(full_name, ' ')) " +
						"= 'Лариса' GROUP BY full_name) AS T; ", connection);

					statistics.readersCountByName = new Dictionary<string, int>();

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							statistics.readersCountByName[reader.GetString(0)] = reader.GetInt32(1);
						}
					}

					connection.Close();
				}
			}
			catch{
				return statistics;
			}

			return statistics;
		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			var connection = GetConnection(LOCAL_DATABASE);
			Statistics statistics = await Task.Run(() =>
			{
				return GetStatistics(connection);
			});

			var genresInfo = String.Join(
				"\n",
				statistics.booksCountByGenre
				.Select(x => x.Key)
				.OrderBy(x => x)
				.Select(x => $" - {x}: {statistics.booksCountByGenre[x]}")
			);

			var namesInfo = String.Join(
				"\n",
				statistics.readersCountByName
				.Select(x => x.Key)
				.OrderBy(x => x)
				.Select(x => $" - {x}: {statistics.readersCountByName[x]}")
				);

			_lblStatistics.Text = $"Общее количество книг: {statistics.booksCount}\n"
				+ $"{genresInfo}" + "\n----------------------------\n"
				+ $"Общее число читателей: {statistics.readersCount}\n"
				+ $"{namesInfo}";
		}
	}

	public class Statistics
	{
		/// <summary>
		/// Количество читателей
		/// </summary>
		public int readersCount;

		/// <summary>
		/// Количество книг
		/// </summary>
		public int booksCount;

		/// <summary>
		/// Количество книг по жанрам
		/// </summary>
		public Dictionary<string, int> booksCountByGenre;

		/// <summary>
		/// Количество читателей по имени
		/// </summary>
		public Dictionary<string, int> readersCountByName;
	}

	public struct ProgressInfo
	{
		public int value;
		public string info;
	}
}
