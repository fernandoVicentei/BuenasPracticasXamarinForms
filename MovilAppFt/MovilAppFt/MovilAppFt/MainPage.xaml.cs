using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MovilAppFt.Vistas;
namespace MovilAppFt
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vistas.Menu());
        }
    }//pruebita  --pass= Katetitos123
    //"Data Source=SQL5103.site4now.net;Initial Catalog=DB_A7176C_pruebita;User Id=DB_A7176C_pruebita_admin;Password=Katetitos123

}
