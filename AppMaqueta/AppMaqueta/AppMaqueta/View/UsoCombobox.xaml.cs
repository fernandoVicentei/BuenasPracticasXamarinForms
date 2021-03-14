using AppMaqueta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMaqueta.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsoCombobox : ContentPage
    {
        List<Coloritem> colors;
        public UsoCombobox()
        {
            InitializeComponent();
            InitApp();
            this.Title = "Colores";
        }

        void InitApp()
        {
            colors = new List<Coloritem>();
            colors.Add(new Coloritem { Colo=Color.Aqua,Name="Aquea"} );
            colors.Add(new Coloritem { Colo = Color.Black, Name = "Black" });
            colors.Add(new Coloritem { Colo = Color.AliceBlue, Name = "AliceBlue" });
            colors.Add(new Coloritem { Colo = Color.Azure, Name = "Azure" });
            colors.Add(new Coloritem { Colo = Color.Blue, Name = "Blue" });
            colors.Add(new Coloritem { Colo = Color.Crimson, Name = "Crimson" });

            foreach (var color in colors)
            {
                pickercolor.Items.Add(color.Name);
            }



        }


        private void pickercolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = pickercolor.SelectedIndex;
            if (pos>-1)
            {
                boxcolor.Color = colors[pos].Colo;
            }
        }
    }
}