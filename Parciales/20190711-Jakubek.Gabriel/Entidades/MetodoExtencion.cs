using System;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class MetodoExtencion
    {
        public static void Planchar(this Aeropuerto<IAvion> emisor)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConeccion);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            try
            {
                comando.CommandText = "INSERT INTO Bitacora (entrada,alumno) VALUES('" + DateTime.Now + "','Jakubek Gabriel')";
                comando.Connection.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
        }
    }
}
