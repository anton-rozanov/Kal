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
    public partial class DayInfo : ContentPage
    {
        
        public DayInfo()
        {
            InitializeComponent();
            RedrawList();
           
        }
        private async void AddNotification(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddNotificationPage(this));
        }


        private async void AddTask(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddTaskPage(this));
        }


        public void RedrawList()
        {
            Content.Children.Clear();
            Label taskL = new Label();
            taskL.Text = "Tasks";
            taskL.Margin = 50;
            Content.Children.Add(taskL);
            

            for (int i = 0; i < Data.data[Data.qrentDay].tasks.Content.Count(); i++)
            {
                Button task = new Button();
                task.Text = Data.data[Data.qrentDay].tasks.Content[i].time.hours + ":" + Data.data[Data.qrentDay].tasks.Content[i].time.minute + " - " + Data.data[Data.qrentDay].tasks.Content[i].name;
                task.Margin = 3;

                Content.Children.Add(task);
            }
            Label notL = new Label();
            notL.Text = "Notifications";
            notL.Margin = 50;
            Content.Children.Add(notL);
            for (int i = 0; i < Data.data[Data.qrentDay].notification.Notification.Count(); i++)
            {
                Button not = new Button();
                not.Text = Data.data[Data.qrentDay].notification.Notification[i].time.hours + ":" + Data.data[Data.qrentDay].notification.Notification[i].time.minute + " - " + Data.data[Data.qrentDay].notification.Notification[i].name;
                not.Margin = 3;

                Content.Children.Add(not);
            }
        }
    }
}