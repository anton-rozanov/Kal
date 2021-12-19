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
    public partial class AddTaskPage : ContentPage
    {
        public Page Parent;
        public AddTaskPage()
        {
            InitializeComponent();
        }
        public AddTaskPage(Page p)
        {
            InitializeComponent();
            this.Parent = p;
        }
        public async void OnButtonAddClick(object sender, System.EventArgs e)
        {
            time t = new time(0, int.Parse(Hour.Text), int.Parse(Minute.Text));
            Data.data[Data.qrentDay].tasks.addTask(new Task(Name.Text,DopName.Text, t));
            DayInfo d = (DayInfo)this.Parent;
            d.RedrawList();
            await Navigation.PopAsync();
        }
    }
}