using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EjercicioSQLWF
{
    public partial class Form1 : Form
    {
        List<Provincias> provincias;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            provincias = new List<Provincias>();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.MiCadenaSQL);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "SELECT Id, Nombre FROM Provincias";
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                provincias.Add(new Provincias((int)((decimal)reader["Id"]) ,reader["Nombre"].ToString()));
            }
            this.cboProvincia.DataSource = provincias;
            conexion.Close();
            //MessageBox.Show(Properties.Settings.Default.MiCadenaSQL);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.MiCadenaSQL);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            string consulta = "INSERT INTO Localidades (ProvinciaId, Nombre) Values('"+((Provincias)cboProvincia.SelectedItem).Id+"','"+ txtLocalidad.Text + "')";
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
