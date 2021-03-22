using MovilAppFt.Conexion;
using Org.W3c.Dom;
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
    public partial class FallasProduccion : ContentPage
    {
        Conex conex = new Conex();
        Parametro pam;
        public FallasProduccion()
        {
            InitializeComponent();
            
            cargardatos();

        }

        void cargardatos()
        {
            List<Parametro> lista = new List<Parametro>();
            string sentencia = "select id,nombre from parametros where grupo='CE'";
            var data = conex.ejecutarConsulta(sentencia);
            foreach (DataRow item in data.Rows)
            {
                lista.Add(new Parametro() { nombre =Convert.ToString(item[1].ToString()),ID=int.Parse(item[0].ToString()) });
            }
            equipos.ItemsSource = lista;
            equipos.ItemDisplayBinding = new Binding("nombre");
            equipos.Title = "Seleccionar";
        }
        private void equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = equipos.SelectedIndex;
            string selec = String.Empty;
            if (pos > -1)
            {
                //selec = equipos.Items[pos].ToString();
                var dd = equipos.SelectedItem;
                pam =(Parametro)dd;
                string dddd =pam.ID.ToString();
            }
            cargarsec();
        }

        void cargarsec()
        {
            List<Parametro> lista = new List<Parametro>();
            string sentencia = "select id,nombre from parametros where grupo='SEC'";
            var data = conex.ejecutarConsulta(sentencia);
            foreach (DataRow item in data.Rows)
            {
                lista.Add(new Parametro() { nombre = Convert.ToString(item[1].ToString()), ID = int.Parse(item[0].ToString()) });
            }
            sector.ItemsSource = lista;
            sector.ItemDisplayBinding = new Binding("nombre");
        }
        void cargarref1()
        {
            List<Parametro> lista = new List<Parametro>();
            string sentencia = "select id,nombre from parametros where grupo='REF1'";
            var data = conex.ejecutarConsulta(sentencia);
            foreach (DataRow item in data.Rows)
            {
                lista.Add(new Parametro() { nombre = Convert.ToString(item[1].ToString()), ID = int.Parse(item[0].ToString()) });
            }
            referencia0.ItemsSource = lista;
            referencia0.ItemDisplayBinding = new Binding("nombre");
        }
        void cargarref2()
        {
            List<Parametro> lista = new List<Parametro>();
            string sentencia = "select id,nombre from parametros where grupo='REF2'";
            var data = conex.ejecutarConsulta(sentencia);
            foreach (DataRow item in data.Rows)
            {
                lista.Add(new Parametro() { nombre = Convert.ToString(item[1].ToString()), ID = int.Parse(item[0].ToString()) });
            }
            referencia1.ItemsSource = lista;
            referencia1.ItemDisplayBinding = new Binding("nombre");
        }
        private void sector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarref1();
        }

        private void referencia0_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarref2();
        }

        private void referencia1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void _timePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}