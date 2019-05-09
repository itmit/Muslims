using System;
using System.Threading;
using System.Threading.Tasks;
using Muslims.Models.Parser;
using Plugin.LocalNotifications;

namespace Muslims.Models
{
	public static class NamazTimer
	{
		public static async void StartTimer()
		{
			await Task.Run(StartTimerAsync);
		}

		private static void StartTimerAsync()
		{
			var parser = new NamazTimeParser();
			var timeList = parser.GetTodayNamazTimes();
			TimerCallback tm = CheckNamazTime;
			var unused = new Timer(tm, timeList, 0, 60 * 1000);
		}

		#region Public
		private static void CheckNamazTime(object obj)
		{
			if (obj is NamazTimesRow namazTime)
			{
				if (CheckTime(namazTime))
				{
					CrossLocalNotifications.Current.Show("Намаз!", "До Намаза осталось 30 минут!");
				}
			}
		}

		public static bool CheckTime(NamazTimesRow namazTime)
		{
			var hours = DateTime.Now.Hour;
			var minutes = DateTime.Now.Minute;
			if (minutes + 30 >= 60)
			{
				hours = hours + 1;
				minutes = minutes - 30;
			}
			else
			{
				minutes = minutes + 30;
			}

			var time = hours + ":" + minutes.ToString("D2");

			return time == namazTime.FirstNamaz ||
				   time == namazTime.SecondNamaz ||
				   time == namazTime.ThirdNamaz ||
				   time == namazTime.FourthNamaz ||
				   time == namazTime.FifthNamaz ||
				   time == namazTime.SixthNamaz;
		}
		#endregion
	}
}
