using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace com.shome.App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Label1.Text = DateTime.Now.ToString("hh:mm:ss.fff");
                await Task.Delay(500);
            }
        }
    }
}