using System;
using System.Windows.Input;
using WhereIsDotNet.Services;
using Xamarin.Forms;

namespace WhereIsNetShell.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            //   OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
               OpenWebCommand = new Command(() => GenerateMockData());

        }

        public ICommand OpenWebCommand { get; }

        public void GenerateMockData()
        {
            var service = new AzureDevicesService();
            service.PopulateCosmosDbWithSamples();
        }
    }
}