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
    public class GetAllCompanias : ContentPage
    {
        private ListView lista;
        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "mydb.db3");

        public GetAllCompanias()
        {
            this.Title = "Compañia";
            var db = new SQLiteConnection(path);

            StackLayout stack = new StackLayout();
            lista = new ListView();
            lista.ItemsSource = db.Table<Company>().OrderBy(x=> x.Name).ToList();
            stack.Children.Add(lista);

            Content = stack;
                         
        }
    }
}