using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class Day
    {
        public ListOfNotification notification = new ListOfNotification();
        public ListOfTasks tasks = new ListOfTasks();
        public int number;
        public Month month;
        public Day(int number, Month month)
        {
            this.month = month;
            this.number = number;
        }
        
    }
}
