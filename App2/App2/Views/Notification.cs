using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    public class Notification
    {
        public string name;
        public time time;
        public Notification(string name, time time)
        {
            this.name = name;
            this.time = time;

        }
        public bool isDone()
        {
            if (DateTime.Now.Second >= time.second && DateTime.Now.Minute >= time.minute && DateTime.Now.Hour >= time.hours && DateTime.Now.Day >= time.day && DateTime.Now.Month >= time.month && DateTime.Now.Year >= time.year)
            {
                return true;
            }
            return false;
        }
    }
}
