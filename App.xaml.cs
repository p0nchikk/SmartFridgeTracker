using RegisterLogin.Views;
//using Windows.ApplicationModel.Activation;

namespace RegisterLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ScanItemPage());
        }
    }
}
