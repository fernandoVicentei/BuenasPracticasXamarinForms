using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RazasView : ContentPage
    {
        public RazasView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MainPage ma = new MainPage();
            await Navigation.PushModalAsync(ma);
        }
    }
}