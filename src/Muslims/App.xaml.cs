using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Muslims.Models;
using Muslims.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Muslims
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
			try
			{
				NamazTimer.StartTimer();
			}
            catch (Exception e)
			{
				Console.WriteLine(e);
			}
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
