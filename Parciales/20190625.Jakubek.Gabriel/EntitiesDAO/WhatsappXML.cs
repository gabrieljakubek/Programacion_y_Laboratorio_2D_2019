using Entities;
using EntitiesDAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Persistencia
{
  public class WhatsappXml : IData<List<EmisorDeWhatsapp>>
  {
    private readonly string path;

    /// <summary>
    /// Le asigna un valor al path.
    /// </summary>
    public WhatsappXml()
    {
      path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whatsappXml.txt";
    }

    public void Guardar(Emisor emisor)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(Emisor));
      try
      {
        using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
        {
          serializer.Serialize(writer, emisor);
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public List<EmisorDeWhatsapp> Leer()
    {
      List<EmisorDeWhatsapp> emisores;
      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Emisor>));
        using (XmlTextReader reader = new XmlTextReader(path))
        {
          emisores = (List<EmisorDeWhatsapp>)serializer.Deserialize(reader);
        }
        return emisores;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
