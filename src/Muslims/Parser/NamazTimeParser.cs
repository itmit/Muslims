using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.App;
using CsvHelper;
using Muslims.Models;

namespace Muslims.Parser
{
	internal class NamazTimeParser
	{


		#region .ctor
		public NamazTimeParser()
		{
			if (NamazTimesRows == null)
			{
				NamazTimesRows = new List<NamazTimesRow>();
				var stream = Application.Context.Assets.Open("wtf.csv");
				using (var reader = new StreamReader(stream))
				{
					var csv = new CsvReader(reader);
					csv.Configuration.Delimiter = ";";
					csv.Configuration.MissingFieldFound = null;
					while (csv.Read())
					{
						NamazTimesRows.Add(csv.GetRecord<NamazTimesRow>());
					}
				}
			}
		}
		#endregion

		#region Properties
		public static List<NamazTimesRow> NamazTimesRows
		{
			get;
			private set;
		}
		#endregion

		#region Public
		public NamazTimesRow GetTodayNamazTimes()
		{
			return NamazTimesRows.Single(row => row.Day == DateTime.Now.Day.ToString() && row.Mouth == DateTime.Now.Month.ToString());
		}
		#endregion
	}
}
