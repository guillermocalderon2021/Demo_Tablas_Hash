using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_Hash
{
    class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string n, int e, DateTime f)
        {
            this.Edad = e;
            this.Nombre = n;
            this.FechaNacimiento = f;
        }
    }
}
