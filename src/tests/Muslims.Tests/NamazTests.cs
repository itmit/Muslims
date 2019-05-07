using System;
using Muslims.Models;
using NUnit.Framework;

namespace Muslims.Tests
{
	[TestFixture]
	public class NamazTests
	{
		#region Test methods
		[Test]
		[Description("Проверка на правильность работы таймера для пуш уведомления о скором намазе.")]
		public void CheckNamazTimer()
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

			var timeString = hours + ":" + minutes;

			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				FirstNamaz = timeString
			}));
			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				SecondNamaz = timeString
			}));
			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				ThirdNamaz = timeString
			}));
			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				FourthNamaz = timeString
			}));
			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				FifthNamaz = timeString
			}));
			Assert.IsTrue(NamazTimer.CheckTime(new NamazTimesRow
			{
				Day = DateTime.Now.Day.ToString(),
				Mouth = DateTime.Now.Month.ToString(),
				SixthNamaz = timeString
			}));
		}
		#endregion
	}
}
