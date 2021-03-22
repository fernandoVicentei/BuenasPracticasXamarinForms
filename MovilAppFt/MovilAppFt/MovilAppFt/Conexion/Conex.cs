using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MovilAppFt.Conexion
{
    public class Conex
    {
        static string cadenaConexion = @"data source=SQL5103.site4now.net;initial catalog=DB_A7176C_pruebita;user id=DB_A7176C_pruebita_admin;password=Katetitos123;Connect Timeout=30";
        //"Data Source=SQL5103.site4now.net;Initial Catalog=DB_A7176C_pruebita;User Id=DB_A7176C_pruebita_admin;Password=Katetitos123

        public static List<Parametro> ObtenerEmpleados()
        {
            List<Parametro> listaEmpleados = new List<Parametro>();
            string sql = "SELECT * FROM parametros";

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {                        
                        while (reader.Read())
                        {
                            Parametro empleado = new Parametro()
                            {
                                ID = reader.GetInt32(0),
                                nombre = reader.GetString(1),
                                grupo = reader.GetString(2)
                            };

                            listaEmpleados.Add(empleado);
                        }
                    }
                }
                con.Close();
                return listaEmpleados;
            }
        }
        public DataTable ejecutarConsulta(string sentencia)
        {
            List<Parametro> listaEmpleados = new List<Parametro>();
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();

                using (SqlCommand comando = new SqlCommand(sentencia, con))
                {
                    using (SqlDataAdapter reader = new SqlDataAdapter(comando))
                    {
                        reader.Fill(data);
                    }
                }
                con.Close();
                return data;
            }
        }
    }
}
