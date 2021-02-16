using app2.Models;
using app2.Repository;
using app2.ViewModel;
using app2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RepositoryRaza repo;
        public MainPage()
        {
            InitializeComponent();
            repo = new RepositoryRaza();
            repo.CrearBBDD();
        }
        private async  void btnmostrar_Clicked(object sender, EventArgs e)
        {
            RazasView view = new RazasView();
            await Navigation.PushModalAsync(view);
        }
        private async void btnnuevo_Clicked(object sender, EventArgs e)
        {
            Views.Page1 nuev = new Views.Page1();
            await Navigation.PushModalAsync(nuev);
        }
        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                EliminarRaza eli = new EliminarRaza();
                RazaModel viewmode = new RazaModel();
                int num = int.Parse(this.cajacodigo.Text);
                Raza ra = this.repo.BuscarRaza(num);
                viewmode.Raza = ra;
                eli.BindingContext = viewmode;
                await Navigation.PushModalAsync(eli);
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Inserte numeros correctamente", "OK");
            }           
        }
        private async  void btneditar_Clicked(object sender, EventArgs e)
        {
            try
            {
                ModificarRaza upd = new ModificarRaza();
                RazaModel viewmode = new RazaModel();
                int num = int.Parse(this.cajacodigo.Text);
                Raza ra = this.repo.BuscarRaza(num);
                viewmode.Raza = ra;
                upd.BindingContext = viewmode;
                await Navigation.PushModalAsync(upd);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Inserte numeros correctamente", "OK");
                
            }
            
        }

    }
}
