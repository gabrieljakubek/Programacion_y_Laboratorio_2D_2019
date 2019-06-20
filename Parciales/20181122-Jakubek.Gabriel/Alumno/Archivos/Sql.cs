using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static Sql()
        {
            conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                Patente patente;
                conexion.Open();
                while (datos.Count !=0)
                {
                    patente = datos.Dequeue();
                    comando.CommandText = "INSERT INTO" + tabla + "(patente,tipo) VALUES('" + patente.CodigoPatente + "','" + patente.TipoCodigo + "')";
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            try
            {
                datos = new Queue<Patente>();
                conexion.Open();
                comando.CommandText = "SELECT patente, tipo FROM " + tabla;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    datos.Enqueue(new Patente(reader["patente"].ToString(), (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo), reader["tipo"].ToString())));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
