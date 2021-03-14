using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace BuscadorDatos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConectividadInternet : ContentPage
    {
        public ConectividadInternet()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //comprobamos si contamos con internet o no
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DisplayAlert("Sin Internet", "", "ok");
                //con el return no nos dejara avanzar a otra parte de esta seccion de archivo
                return;
            }
            else
            {
                DisplayAlert("Conectado", "Cuenta con internet", "ok");
            }
        }
    }
}