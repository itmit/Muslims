using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var NamazTimesList = new List<NamazTimeRow>();
			using (TextReader reader = File.OpenText(@"E:/wtf.csv"))
			{
				CsvReader csv = new CsvReader(reader);
				csv.Configuration.Delimiter = ";";
				csv.Configuration.MissingFieldFound = null;
				while (csv.Read())
				{
					NamazTimeRow Record = csv.GetRecord<NamazTimeRow>();
					NamazTimesList.Add(Record);
				}
			}

			NamazTimeRow namazTimeRow = NamazTimesList.Where(row => row.Day == 29 && row.Mouth == 4).Single<NamazTimeRow>();

			Console.WriteLine(namazTimeRow.FirstNamaz);
			Console.WriteLine(namazTimeRow.SecondNamaz);
			Console.WriteLine(namazTimeRow.ThirdNamaz);
			Console.WriteLine(namazTimeRow.FourthNamaz);
			Console.WriteLine(namazTimeRow.FifthNamaz);
			Console.WriteLine(namazTimeRow.SixthNamaz);

			Console.ReadKey();
		}
	}

	/// <summary>
	/// Представляет одну колонку из таблицы проведения намазов, в течении дня.
	/// </summary>
	class NamazTimeRow
	{
		/// <summary>
		/// Возвращает или устанавливает время первого намаза.
		/// </summary>
		public string FirstNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает время второго намаза.
		/// </summary>
		public string SecondNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает время третьего намаза.
		/// </summary>
		public string ThirdNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает время четвертого намаза.
		/// </summary>
		public string FourthNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает время пятого намаза.
		/// </summary>
		public string FifthNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает время шестого намаза.
		/// </summary>
		public string SixthNamaz { get; set; }

		/// <summary>
		/// Возвращает или устанавливает  день проведения намазов.
		/// </summary>
		public int Day { get; set; }

		/// <summary>
		/// Возвращает или устанавливает месяц в котром проводятся намазы.
		/// </summary>
		public int Mouth { get; set; }
	}
}
