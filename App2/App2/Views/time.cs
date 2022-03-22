using System;
using System.Collections.Generic;
using System.Text;
//a
namespace App2.Views
{
    public class time
    {
       public int second;
       public int minute;
       public int hours;
       public int month;
       public int day;
       public int year;
       public bool isiqel(time time)
        {
            if (this.second == time.second && this.minute == time.minute && this.hours == time.hours && this.month == time.month && this.day == time.day && this.year == time.year)
            {
                return true;
            }
            return false;
        }
        public bool isog(time time)
        {
            if (this.second >= time.second && this.minute >= time.minute && this.hours >= time.hours && this.month >= time.month && this.day >= time.day && this.year >= time.year)
            {
                return true;
            }
            return false;
        }
        public time(int second,int minute,int hours)
        {
            this.second = second;
            this.minute = minute;
            this.hours = hours;
            
        }
        public time(int second, int minute, int hours,int day,int month , int year)
        {
            this.second = second;
            this.minute = minute;
            this.hours = hours;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            string a = this.hours + ":" + this.minute + ":" + this.second;
            return a;
        }
        public static time FromString(string input)
        {
            string[] timeDat = input.Split(':');
            return new time(int.Parse(timeDat[0]), int.Parse(timeDat[1]), int.Parse(timeDat[2]));
        }
        // "12:21:51" => FromString() => time : time.hours = 12, time.minute = 21, time.second = 51
    }
}
