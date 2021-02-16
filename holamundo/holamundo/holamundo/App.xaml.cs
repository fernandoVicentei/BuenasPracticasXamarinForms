using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace holamundo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //  sera la pagina de inicio
            MainPage = new Page1();
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
