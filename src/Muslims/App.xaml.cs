using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Muslims.Models;


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
            NamazTimer.StartTimer();
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
