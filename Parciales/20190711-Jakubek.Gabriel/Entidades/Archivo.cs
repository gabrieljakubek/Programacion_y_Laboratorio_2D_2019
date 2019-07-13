using System;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivo <T> where T: IAvion
    {
        public static void Guardar(Aeropuerto<T> aeropuerto)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Aeropuerto<IAvion>));
                using (XmlTextReader reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Vuelos.xml"))
                {
                    aeropuerto = (Aeropuerto<T>)serializer.Deserialize(reader);
                    //carga.Planchar((Aeropuerto<T>)aeropuerto);
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
        }

        public static Aeropuerto<T> Leer()
        {
            Aeropuerto<T> aeropuerto = new Aeropuerto<T>();
            Aeropuerto<IAvion> carga = new Aeropuerto<IAvion>();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Aeropuerto<IAvion>));
                using (XmlTextReader reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Vuelos.xml"))
                {
                    aeropuerto = (Aeropuerto<T>)serializer.Deserialize(reader);
                    //carga.Planchar((Aeropuerto<T>)aeropuerto);
                    return aeropuerto;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
        }
    }
}
