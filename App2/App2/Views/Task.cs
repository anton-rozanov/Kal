using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class Task
    {
       public string name;
       public string dopname;
       public time time;

        public Task(string name,string dopname,time time)
        {
            this.name = name;
            this.dopname = dopname;
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
