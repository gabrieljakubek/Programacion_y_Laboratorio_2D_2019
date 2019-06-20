using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\"+ archivo+ ".txt"))
                {
                    while (datos.Count != 0)
                    {
                        writer.WriteLine(datos.Dequeue().CodigoPatente,true);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Leer(string archivo, out Queue<Patente> dato)
        {
            dato = new Queue<Patente>();
            string auxiliar;
            Patente.Tipo tipo;
            try
            {
                using (StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        dato.Enqueue(PatenteStringExtension.ValidarPatente(reader.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
