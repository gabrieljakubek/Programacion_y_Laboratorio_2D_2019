using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSQLWF
{
    public class Provincias
    {
        public string nombre;
        public int id;

        public int Id { get {return this.id; } set {this.id = value; } }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Provincias(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
