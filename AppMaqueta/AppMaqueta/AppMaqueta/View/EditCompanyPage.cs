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
    public class EditCompanyPage : ContentPage
    {
        private ListView lista;
        private Entry idEntry;
        private Entry nameentry;
        private Entry addresentry;
        private Button btn;

        Company compania = new Company();


        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mydb.db3");
               
        public EditCompanyPage()
        {
            this.Title = "Edit Compania";
            var db = new SQLiteConnection(path);
            StackLayout stack = new StackLayout();

            lista = new ListView();
            lista.ItemsSource = db.Table<Company>().OrderBy(x=>x.Name).ToList();
            lista.ItemSelected += listview_Selected;
            stack.Children.Add(lista);

            idEntry = new Entry();
            idEntry.Placeholder = "ID";
            idEntry.IsVisible = false;
            stack.Children.Add(idEntry);

            nameentry = new Entry();
            nameentry.Placeholder = "Compania Name";
            
            stack.Children.Add(nameentry);

            addresentry = new Entry();
            addresentry.Placeholder = "Compania Address";
           
            stack.Children.Add(addresentry);

            btn = new Button();
            btn.Text = "Update";
            btn.Clicked += _button_clicked;
            stack.Children.Add(btn);

            Content = stack;
        }

        private async void _button_clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(path);
            Company compa = new Company()
            {
                Id = int.Parse(idEntry.Text.ToString()),
                Name = nameentry.Text.ToString(),
                Addres = addresentry.Text.ToString()

            };
            db.Update(compa);
            await Navigation.PopAsync();
        }

        private void listview_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            //lo que ace aca es ponerle al objeto lo que esta selccionado de la lista, como tambien la lista proviene dse alli
            compania = (Company)e.SelectedItem;
            idEntry.Text = compania.Id+"";
            nameentry.Text = compania.Name;
            addresentry.Text = compania.Addres;
        }
    }
}