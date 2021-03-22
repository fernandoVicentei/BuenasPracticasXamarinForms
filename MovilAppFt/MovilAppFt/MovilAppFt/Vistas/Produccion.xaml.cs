using MovilAppFt.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovilAppFt.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Produccion : ContentPage
    {
        Conex conex = new Conex();
        public Produccion()
        {
            InitializeComponent();
            plantas.Title = "Seleccionar";
            plantas.Items.Add("Don Valentin");
            plantas.Items.Add("10 Hectareas");
            centrotrab.Title = "Seleccionar";
            cargardatos();
        }
        void cargardatos()
        {
            List<Parametro> lista = new List<Parametro>();
            string sentencia = "select id,nombre from parametros where grupo='CE'";
            var data = conex.ejecutarConsulta(sentencia);
            foreach (DataRow item in data.Rows)
            {
                lista.Add(new Parametro() { nombre = Convert.ToString(item[1].ToString()), ID = int.Parse(item[0].ToString()) });
            }
            centrotrab.ItemsSource = lista;
            centrotrab.ItemDisplayBinding = new Binding("nombre");
        }
        private void centrotrab_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
        }
        private void plantas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}