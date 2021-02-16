using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace holamundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            /*Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Text = "Primer App"
            };*/
           
        }
        //este se creo con el clicked automatizado de windows forms
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Titulo","Hola mundo","Cancelar","Aceptar");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //slid.Text = String.Format("Numero: {0:F2}",e.NewValue);
        }
    }
}