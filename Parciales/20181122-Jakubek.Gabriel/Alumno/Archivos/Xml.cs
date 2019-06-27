using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

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
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
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
