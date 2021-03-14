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
    public class AddCompany : ContentPage
    {
        private Entry _nameentry;
        private Entry _addressentry;
        private Button _savebuton;
        //creacion de una base de datos en sqlite3
        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"mydb.db3");

        public AddCompany()
        {
            this.Title = "Add Compañia";
            StackLayout stack = new StackLayout();
            _nameentry = new Entry();
            _nameentry.Keyboard = Keyboard.Text;
            _nameentry.Placeholder = "Company Name";
            stack.Children.Add(_nameentry);
            
            _addressentry = new Entry();
            _addressentry.Keyboard = Keyboard.Text;
            _addressentry.Placeholder = "Company Address";
            stack.Children.Add(_addressentry);
            
            _savebuton = new Button();
            _savebuton.Text = "Add";
            _savebuton.Clicked += _savebuton_Clicked;
            stack.Children.Add(_savebuton);

            Content = stack;
            
        }

        private async void _savebuton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(path);
            db.CreateTable<Company>();

            var maxPk = db.Table<Company>().OrderByDescending(c=> c.Id).FirstOrDefault();
            Company compa = new Company();

            Company company = new Company()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameentry.Text,
                Addres = _addressentry.Text
            };
            db.Insert(company);
            await DisplayAlert(null,company.Name+" Guardar","OK");
            await Navigation.PopAsync();
        }
    }
}