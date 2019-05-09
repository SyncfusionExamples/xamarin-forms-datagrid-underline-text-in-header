using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataGridDemo
{
    public partial class App : Application
    {
        public App()
        {

            //Register Syncfusion license
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI0MzlAMzEzNjJlMzQyZTMwTU5PRWlmc0hTRzlzMnpibFFLakpnWUVxd1JsVUw2WW9tdnFmT0dycHEwVT0=");

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
