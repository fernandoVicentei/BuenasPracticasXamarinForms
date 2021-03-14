using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuscadorDatos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //navigation.popasync(); con esto volvemos a la pagina de donde provenimos 
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;
        }


    }
}
