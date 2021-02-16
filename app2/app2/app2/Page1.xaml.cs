using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            label.TextColor = Color.Black;
            slider.Value = 0.5;
        }
      /*  private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            if (e.OldValue > 0.5)
            {
                label.TextColor = Color.Red;
                label.Text = String.Format("Numero : {0:F2}", e.NewValue);
            }
            else
            {
                label.Text = String.Format("Numero : {0:F2}", e.OldValue);
                label.TextColor = Color.Black;
            }
        
        }*/
    }
}