using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilAppFt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {

                //con el return no nos dejara avanzar a otra parte de esta seccion de archivo
                //return;
                MainPage = new NavigationPage(new SinConexion());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }           
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
