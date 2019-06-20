using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".xml", Encoding.UTF8))
                {
                    serializer.Serialize(writer, datos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Leer(string archivo, out T dato)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(string));
            try
            {
                using (XmlTextReader reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".xml"))
                {
                    dato = (T)serializer.Deserialize(reader);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
