using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app2.Models
{
    [Table("Perros")]
    public class Raza
    {
        [PrimaryKey]
        public int Cod { get; set; }
        public string nombre { get; set; }
        public string caracteristicas { get; set; }

    }
}
