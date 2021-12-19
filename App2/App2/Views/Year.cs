using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class Year
    {
        public List<Month> Months = new List<Month>();
        public int yearNumber;
        public Year(int yearNumber,List<Month> Months)
        {
            this.yearNumber = yearNumber;
            this.Months = Months;

        }
    }
}
