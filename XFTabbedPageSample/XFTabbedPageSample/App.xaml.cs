using Xamarin.Forms;
using XFTabbedPageSample.Pages.Tab.Root;

namespace XFTabbedPageSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabRootPage();
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
