using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_Hash
{
    class Program
    {
        static void Main_(string[] args)
        {
            Hashtable tablaNombre = new Hashtable();
            tablaNombre.Add("p1", new Persona("Guillermo",27,DateTime.Now));
            tablaNombre.Add("p2", new Persona("Carmen", 27, DateTime.Now));
            tablaNombre.Add("p3", new Persona("Maria", 27, DateTime.Now));
            tablaNombre.Add("p4", new Persona("Diego", 27, DateTime.Now));
            Console.WriteLine(((Persona)tablaNombre["p2"]).Nombre);

            foreach (var item in tablaNombre.Keys)
            {
                Persona p = (Persona) tablaNombre[item];
                Console.WriteLine("Nombre: {0}, Edad: {1}", p.Nombre, p.Edad);
            }
            
            
            
            Console.ReadKey();

        }
    }
}
