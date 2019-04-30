using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using CsvHelper;
using Muslims.Models;
using Android.Content.Res;
using Android;

namespace Muslims.Parser
{
    class NamazTimeParser
    {
        public NamazTimeParser()
        {
        }

        public NamazTimeRows NamazTimeDates()
        {
            var NamazTimesList = new List<NamazTimeRows>();
            var stream = Android.App.Application.Context.Assets.Open("wtf.csv");
            using (StreamReader reader = new StreamReader(stream))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ";";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    NamazTimeRows Record = csv.GetRecord<NamazTimeRows>();
                    NamazTimesList.Add(Record);
                }
            }
            NamazTimeRows namazTimeRow = NamazTimesList.Where(row => row.Day == DateTime.Now.Day.ToString() && row.Mouth == DateTime.Now.Month.ToString()).Single<NamazTimeRows>();
            return namazTimeRow;
        }
    }
}
