using MovilAppFt.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilAppFt.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Historial : ContentPage
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btnNuevo_Clicked(object sender, EventArgs e)
        {

        }

        private void lsvEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvEmpleados.ItemsSource = Conex.ObtenerEmpleados();
        }
    }
}