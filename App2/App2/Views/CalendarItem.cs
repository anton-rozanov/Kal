using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class CalendarItem
    {
        int ownedId;
        time taskTime;
        string itemName;
        string itemContains;
        bool isNotificational;

        public CalendarItem(time a, string b, string c)
        {
            this.taskTime = a;
            this.itemName = b;
            this.itemContains = c;
        }
    }
}
