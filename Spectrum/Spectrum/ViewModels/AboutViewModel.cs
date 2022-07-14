using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Spectrum.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            OpenWebCommand = new Command(async () => await Shell.Current.GoToAsync("//ItemsPage"));
        }

        public ICommand OpenWebCommand { get; }
    }
}