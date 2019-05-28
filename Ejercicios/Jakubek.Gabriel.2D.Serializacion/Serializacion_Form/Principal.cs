using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializacion_Form
{
    public partial class Principal : Form
    {
        XmlSerializer xmlSerializer;
        XmlTextWriter writer;
        List<Personas> personas;
        XmlTextReader reader;
        FileStream stream;
        BinaryFormatter formatter;
        public Principal()
        {
            InitializeComponent();
            this.personas = new List<Personas>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formulario formulario = new Formulario();
            if (formulario.ShowDialog() == DialogResult.OK) ;
            {
                this.personas.Add(formulario.persona);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (lbxXml.Items.Count == 0)
            {
                lbxXml.DataSource = personas;
                lbxBinario.DataSource = personas;
            }
            else
            {
                lbxXml.DataSource = null;
                lbxBinario.DataSource = null;
                lbxXml.DataSource = personas;
                lbxBinario.DataSource = personas;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\xmlArchivo",Encoding.UTF8);
            this.xmlSerializer = new XmlSerializer(typeof(List<Personas>));
            this.xmlSerializer.Serialize(writer, personas);
            writer.Close();
            stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\xmlArchivoBinario", FileMode.Create);
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, personas);
            stream.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\xmlArchivo"))
            {
                this.reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\xmlArchivo");
                this.xmlSerializer = new XmlSerializer(typeof(List<Personas>));
                personas = (List<Personas>)xmlSerializer.Deserialize(reader);
                reader.Close();
                lbxXml.DataSource = personas;
            }
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\xmlArchivoBinario"))
            {
                stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\xmlArchivoBinario", FileMode.Open);
                formatter = new BinaryFormatter();
                personas = (List<Personas>)formatter.Deserialize(stream);
                stream.Close();
                lbxBinario.DataSource = personas;
            }
        }
    }
}
