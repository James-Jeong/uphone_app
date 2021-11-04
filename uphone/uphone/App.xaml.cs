using Xamarin.Forms;

namespace uphone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new CallPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
