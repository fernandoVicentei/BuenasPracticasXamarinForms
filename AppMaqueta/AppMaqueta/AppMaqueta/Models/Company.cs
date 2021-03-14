using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMaqueta.Models
{
    public class Company
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres
        {
            get; set;
        }

        public override string ToString()
        {
            return this.Name + "(" + this.Addres + ")";
        }
    }
}
