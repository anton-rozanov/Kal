using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class Month
    {
        public int dayScount;
        public string mounthName;
        public List<Day> Days = new List<Day>();
        public Month(int dayScount, string mounthName, List<Day> Days)
        {
            this.Days = Days;
            this.dayScount = dayScount;
            this.mounthName = mounthName;
        }
    }
}
