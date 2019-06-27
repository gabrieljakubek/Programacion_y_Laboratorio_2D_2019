using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entities;
using EntitiesDAO;

namespace Persistencia
{
  public class EmailDB : IData<List<EmisorDeEmails>>
  {
    private readonly string connectionString;

    /// <summary>
    /// Asigna un valor al connectionString
    /// </summary>
    public EmailDB()
    {
      connectionString = EntitiesDAO.Properties.Settings.Default.CadenaConexion;
    }

    public void Guardar(Emisor emisor)
    {
      SqlConnection conexion = new SqlConnection(connectionString);
      SqlCommand comando = new SqlCommand();
      comando.CommandType = CommandType.Text;
      comando.Connection = conexion;
      try
      {
        conexion.Open();
        comando.CommandText = "INSERT INTO Emails2 (mensaje,producto,email) VALUES('" + ((EmisorDeEmails)emisor).Mensaje + "','" + ((EmisorDeEmails)emisor).Producto.ToString() + "','" + ((EmisorDeEmails)emisor).Email+ "')";
        comando.ExecuteNonQuery();
      }
      catch (Exception)
      {
      }
      finally
      {
        if (conexion.State == ConnectionState.Open)
        {
          conexion.Close();
        }
      }
    }

    public List<EmisorDeEmails> Leer()
    {
      SqlConnection conexion = new SqlConnection(connectionString);
      SqlCommand comando = new SqlCommand();
      comando.CommandType = CommandType.Text;
      comando.Connection = conexion;
      List<EmisorDeEmails> emisores = new List<EmisorDeEmails>();
      try
      {
        conexion.Open();
        comando.CommandText = "SELECT mensaje,producto,email FROM Emails2";
        SqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
          emisores.Add(new EmisorDeEmails(reader["mensaje"].ToString(), (EProducto)Enum.Parse(typeof(EProducto), reader["producto"].ToString()), reader["email"].ToString()));
        }
      }
      catch (Exception)
      {
      }
      finally
      {
        if (conexion.State == ConnectionState.Open)
        {
          conexion.Close();
        }
      }
      return emisores;
    }
  }
}
