using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuscadorDatos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventas : ContentPage
    {
        public Ventas()
        {
            InitializeComponent();
        }
        async void MostrarAlertaClicked(object sender,EventArgs e)
        {
            await DisplayAlert("Alerta","Hola, como estas","ok");
        }

        async void PreguntaClicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("Aceptas? ","Deseas aceptar las condiciones?","Si","No");
            await DisplayAlert( "Mensaje",respuesta ? "Aceptaste":"No Aceptaste","Ok");
            //ahora mostraremos como para un selector de datos en un modal
            //string opcion = await DisplayActionSheet("Seleccionar pais","Cancelar",null,"Bolivia","Meximo","Peru");
        }
    }
}