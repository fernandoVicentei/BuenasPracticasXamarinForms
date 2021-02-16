using app2.Dependencias;
using app2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace app2.Repository
{
    public class RepositoryRaza
    {
        private SQLiteConnection cn;

        public RepositoryRaza()
        {
            this.cn = DependencyService.Get<Interface1>().GetConnection();
        }

        public void CrearBBDD()
        {
            this.cn.DropTable<Raza>();
            this.cn.CreateTable<Raza>();
        }
        public List<Raza> GetRazas()
        {
            var consulta = from datos in cn.Table<Raza>()
                           select datos;
            return consulta.ToList();
        }
        public Raza BuscarRaza(int num)
        {
            var consulta = from datos in cn.Table<Raza>()
                           where datos.Cod == num
                           select datos;
            return consulta.FirstOrDefault();
        }
        public void InsertarRaza(int num, string nomb,string caracteristica)
        {
            Raza ra = new Raza();
            ra.Cod = num;
            ra.nombre = nomb;
            ra.caracteristicas = caracteristica;
            this.cn.Insert(ra);
        }
        public void ActualizarRaza(int num, string nomb, string caracteristica)
        {
            Raza ra = this.BuscarRaza(num);           
            ra.nombre = nomb;
            ra.caracteristicas = caracteristica;
            this.cn.Update(ra);
        }

        public void EliminarRaza(int num)
        {
            Raza ra = this.BuscarRaza(num);
            this.cn.Delete<Raza>(ra);
        }
    }
}
