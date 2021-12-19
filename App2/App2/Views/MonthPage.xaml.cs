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
    public partial class MonthPage : ContentPage
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "Jule", "August", "September", "October", "November", "December" };
        public MonthPage()
        {
            InitializeComponent();
            int colomnum = 0;
            int rownum = 1;
            
            for (int i = 1; i <= 12; i++)
            {

                Button redBox = new Button();
                redBox.Clicked += OnButtonClicked;
                redBox.Text = months[i-1];
                CGrid.Children.Add(redBox, colomnum, rownum);
                if (i % 3 == 0)
                {
                    rownum = rownum + 1;
                    colomnum = 0;
                }
                else
                {
                    colomnum += 1;
                }
                

            }
            
        }
        public int search(string[] months,string search)
        {
            if (search == months[0])
            {
                return 0;
            }

            if (search == months[1])
            {
                return 1;
            }


            if (search == months[2])
            {
                return 2;
            }


            if (search == months[3])
            {
                return 3;
            }


            if (search == months[4])
            {
                return 4;
            }


            if (search == months[5])
            {
                return 5;
            }


            if (search == months[6])
            {
                return 6;
            }


            if (search == months[7])
            {
                return 7;
            }


            if (search == months[8])
            {
                return 8;
            }

            if (search == months[9])
            {
                return 9;
            }


            if (search == months[10])
            {
                return 10;
            }


            if (search == months[11])
            {
                return 11;
            }
            return -1;
        }

        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button t = (Button)sender;

            Data.qrentMonth = search(months,t.Text);

            await Navigation.PushAsync(new CalendarPage());
        }
    }
}