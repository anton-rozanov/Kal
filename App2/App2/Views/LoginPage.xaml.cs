using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            List<Day> days = new List<Day>();
            for (int i = 0; i < 365; i++)
            {
                Data.data[i] = new Day(i + 1,null);
                days.Add(Data.data[i]);
            }
            List<Month> months = new List<Month>();
            List<Day> days1 = new List<Day>();
            Month jan = new Month(31, "January", days1);
            for (int i = 0; i < 31; i++)
            {
                days[i].month = jan;
                days1.Add(days[i]);
            }
            months.Add(jan);
            List<Day> days2 = new List<Day>();
            Month feb = new Month(28, "February", days2);
            for (int i = 31; i < 59; i++)
            {
                days[i].month = feb;
                days2.Add(days[i]);
            }
            months.Add(feb);

            List<Day> days3 = new List<Day>();
            Month mar = new Month(31, "March", days3);
            for ( int i = 59; i < 90; i++)
            {
                days[i].month = mar;
                days3.Add(days[i]);
            }
            months.Add(mar);

            List<Day> days4 = new List<Day>();
            Month apr = new Month(30, "April", days4);
            for(int i = 90; i < 120; i++)
            {
                days[i].month = apr;
                days4.Add(days[i]);
            }
            months.Add(apr);

            List<Day> days5 = new List<Day>();
            Month may = new Month(31, "May", days5);
            for (int i = 120; i < 151; i++)
            {
                days[i].month = may;
                days5.Add(days[i]);
            }
            months.Add(may);

            List<Day> days6 = new List<Day>();
            Month jun = new Month(30, "June", days6);
            for (int i = 151; i < 181; i++)
            {
                days[i].month = jun;
                days6.Add(days[i]);
            }
            months.Add(jun);

            List<Day> days7 = new List<Day>();
            Month jul = new Month(31, "Jule", days7);
            for (int i = 181; i < 212; i++)
            {
                days[i].month = jul;
                days7.Add(days[i]);
            }
            months.Add(jul);

            List<Day> days8 = new List<Day>();
            Month aug = new Month(31, "August", days8);
            for (int i = 212; i < 243; i++)
            {
                days[i].month = aug;
                days8.Add(days[i]);
            }
            months.Add(aug);

            List<Day> days9 = new List<Day>();
            Month sep = new Month(30, "September", days9);
            for (int i = 243; i < 273; i++)
            {
                days[i].month = sep;
                days9.Add(days[i]);
            }
            months.Add(sep);

            List<Day> days10 = new List<Day>();
            Month oct = new Month(31, "October", days10);
            for (int i = 273; i < 304; i++)
            {
                days[i].month = oct;
                days10.Add(days[i]);
            }
            months.Add(oct);

            List<Day> days11 = new List<Day>();
            Month nov = new Month(30, "November", days11);
            for (int i = 304; i < 334; i++)
            {
                days[i].month = nov;
                days11.Add(days[i]);
            }
            months.Add(nov);

            List<Day> days12 = new List<Day>();
            Month dec = new Month(31, "December", days12);
            for (int i = 334; i < 365; i++)
            {
                days[i].month = dec;
                days12.Add(days[i]);
            }
            months.Add(dec);
            Data.months = months;

            
        }
        private async void OnLoginClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MonthPage());
        }
    }
}