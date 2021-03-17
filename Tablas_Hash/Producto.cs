using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_Hash
{
    class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string  Marca { get; set; }

        public Producto(string codigo, string nombre, decimal precio, string marca)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Marca = marca;
        }

        public Producto()
        {
            this.Codigo = "";
            this.Nombre = "";
            this.Precio = 0;
            this.Marca = "";
        }
    }
}
