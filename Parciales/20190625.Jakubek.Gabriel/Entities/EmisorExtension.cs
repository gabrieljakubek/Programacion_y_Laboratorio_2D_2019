namespace Entities
{
  public static class EmisorExtensiones
  {
     public static string Mostrar(this EmisorDeEmails emisor)
    {
      return $"{emisor.ToString()} - {emisor.Email}";
    }

    public static string Mostrar(this EmisorDeWhatsapp emisor)
    {
      return $"{emisor.ToString()} - {emisor.NumeroTelefono}";
    }
  }
}
