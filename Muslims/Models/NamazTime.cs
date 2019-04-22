using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Plugin.LocalNotifications;

namespace Muslims.Models
{
    class NamazTime
    {
        public NamazTime()
        {
            string time = "13:30:00";
            TimerCallback tm = new TimerCallback(NamazTimer);
            Timer timer = new Timer(tm, time, 0, 60000);

            Console.ReadLine();
        }
        public static void NamazTimer(object obj)
        {
            string dt = DateTime.Now.ToLongTimeString();
            if(obj.ToString() == dt)
            {
                CrossLocalNotifications.Current.Show("Время Намаза!", "Пришло время совершить Намаз!");
            }
        }
    }
}
