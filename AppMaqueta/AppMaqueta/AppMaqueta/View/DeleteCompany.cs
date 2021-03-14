using AppMaqueta.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMaqueta.View
{
    public class DeleteCompany : ContentPage
    {

        private ListView lista;
        private Button btn;
        Company compania = new Company();
        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mydb.db3");

        
        public DeleteCompany()
        {
            this.Title = "Delete Compania";
            var db = new SQLiteConnection(path);
            StackLayout stack = new StackLayout();

            lista = new ListView();
            lista.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            lista.ItemSelected += listview_Selected;
            stack.Children.Add(lista);

            btn = new Button();
            btn.Text = "Delete";
            btn.Clicked += button_Clicked;
            stack.Children.Add(btn);


            Content = stack;

        }

        private async void button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(path);
            db.Table<Company>().Delete(x=>x.Id==compania.Id);            
            await Navigation.PopAsync();
        }

        private void listview_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            //lo que ace aca es ponerle al objeto lo que esta selccionado de la lista, como tambien la lista proviene dse alli
            compania = (Company)e.SelectedItem;
           
        }

    }
}