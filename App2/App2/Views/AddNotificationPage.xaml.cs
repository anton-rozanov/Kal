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
    public partial class AddNotificationPage : ContentPage
    {
        public Page Parent;
        public AddNotificationPage()
        {
            InitializeComponent();
        }
        public AddNotificationPage(Page p)
        {
            InitializeComponent();
            this.Parent = p;
        }
        public async void OnButtonAddClick(object sender, System.EventArgs e)
        {
            time t = new time(0, int.Parse(HOURN.Text), int.Parse(MINUTEN.Text));
            Data.data[Data.qrentDay].notification.addNotification(new Notification(NAMEN.Text, t));
            DayInfo d = (DayInfo)this.Parent;
            d.RedrawList();
            await Navigation.PopAsync();
        }
    }
    
}