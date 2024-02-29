using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microcharts;
using Microcharts.Forms;

namespace ScreenTimeApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}