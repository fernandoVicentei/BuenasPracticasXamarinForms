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
    public partial class UbicacioMapa : ContentPage
    {
        public UbicacioMapa()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(txtlatitud.Text,out double lat))
                    return;
            if (!double.TryParse(txtlongitud.Text, out double lon)) 
                    return;
            await Map.OpenAsync(lat, lon, new MapLaunchOptions
            {
                Name=txtname.Text,
                NavigationMode=NavigationMode.None
            });

        }
    }
}