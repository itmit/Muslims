using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Plugin.LocalNotifications;
using Muslims.Parser;
using System.Threading.Tasks;

namespace Muslims.Models
{
    class NamazTime
    {
        public NamazTime()
        {
            NamazTimeParser parser = new NamazTimeParser();
            NamazTimeRows timelist =  parser.NamazTimeDates();
            TimerCallback tm = new TimerCallback(NamazTimer);
            Timer timer = new Timer(tm, timelist, 0, 60 * 1000);

            Console.ReadLine();
        }
        public static void NamazTimer(object obj)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            if((minutes + 30) >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 30;
            }
            else
            {
                minutes = minutes + 30;
            }

            string time = hours.ToString() + ":" + minutes.ToString("D2");

            if (obj is NamazTimeRows namazTime)
            {
                if (time.ToString() == namazTime.FirstNamaz 
                    || time.ToString() == namazTime.SecondNamaz 
                    || time.ToString() == namazTime.ThirdNamaz 
                    || time.ToString() == namazTime.FourthNamaz 
                    || time.ToString() == namazTime.FifthNamaz 
                    || time.ToString() == namazTime.SixthNamaz)
                { 
                    CrossLocalNotifications.Current.Show("Намаз!", "До Намаза осталось 30 минут!");
                }
            }
        }
    }
}
