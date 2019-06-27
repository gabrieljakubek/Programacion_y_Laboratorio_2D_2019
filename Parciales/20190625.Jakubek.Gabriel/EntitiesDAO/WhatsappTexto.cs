using Entities;
using EntitiesDAO;
using System;
using System.IO;

namespace Persistencia
{
  public class WhatsappTexto : IData<string>
  {
    private readonly string path;

    /// <summary>
    /// Asignar valor al path
    /// </summary>
    public WhatsappTexto()
    {
      path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whatsappTexto.txt";
    }

    public void Guardar(Emisor emisor)
    {
      try
      {
        using (StreamWriter writer = new StreamWriter(path,true))
        {
          if (emisor.GetType() == typeof(EmisorDeEmails))
          {
            writer.WriteLine(((EmisorDeEmails)emisor).Mostrar(), true);
          }
          else if(emisor.GetType() == typeof(EmisorDeWhatsapp))
          {
            writer.WriteLine(((EmisorDeWhatsapp)emisor).Mostrar(), true);
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    string IData<string>.Leer()
    {
      string retorno = "";
      try
      {
        using (StreamReader reader = new StreamReader(path))
        {
          while (!reader.EndOfStream)
          {
              retorno +=reader.ReadLine();

          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return retorno;
    }
  }
}
