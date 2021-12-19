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
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
            int colomnum = 0;
            int rownum = 1;
            for (int i = 1; i <= Data.months[Data.qrentMonth].dayScount; i++)
              {
                
                Button redBox = new Button();
                redBox.Clicked += OnButtonClicked;
                redBox.Text = i.ToString();
                CGrid.Children.Add(redBox, colomnum, rownum);
                if(i%7 == 0)
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
        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            Button t = (Button)sender;
            Console.WriteLine(t.Text);
            Data.qrentDay = int.Parse(t.Text);
            
            await Navigation.PushAsync(new DayInfo());
        }
    }
}