using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using app2.Dependencias;
using app2.Droid;
using SQLite;
using Xamarin.Forms;
[assembly : Dependency(typeof(SqliteCliente))]

namespace app2.Droid
{
    public class SqliteCliente : Interface1
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "PERRO.db";
            String rutadocumentos = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            String path = Path.Combine(rutadocumentos, bbddfile);
            SQLite.SQLiteConnection cn = new SQLite.SQLiteConnection(path);
            return cn;
        }

    }
}