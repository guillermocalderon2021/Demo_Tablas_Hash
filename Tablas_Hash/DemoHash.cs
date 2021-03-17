using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_Hash
{
    class DemoHash
    {
        static void Main(string[] args)
        {

            
                Hashtable tablaProductos = new Hashtable();
                Producto aux;
                string codigo = String.Empty;
                while (true)
                {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------ DEMO TABLAS HASH -------------:");
                    Console.WriteLine("1) Agregar producto");
                    Console.WriteLine("2) Mostrar lista de productos");
                    Console.WriteLine("3) Eliminar producto");
                    Console.WriteLine("4) Buscar producto por codigo");
                    Console.WriteLine("5) Buscar producto por nombre");
                    Console.WriteLine("0) Salir");
                    Console.Write("\r\nSelecciona una opcion: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            // Instanciando y llenando el objeto
                            aux = new Producto();
                            Console.WriteLine("Ingresa el codigo del producto:");
                            aux.Codigo = Console.ReadLine();
                            if (tablaProductos.ContainsKey(aux.Codigo))
                            {
                                Console.WriteLine("Ya existe un producto con este código");
                                Console.ReadKey();
                                continue;
                            }
                            Console.WriteLine("Ingresa el nombre del producto:");
                            aux.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa el precio del producto:");
                            aux.Precio = Decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la marca del producto:");
                            aux.Marca = Console.ReadLine();
                            //Insertando el objeto en el Hashmap
                            tablaProductos.Add(aux.Codigo, aux);

                            break;
                        case "2":
                            foreach (var key in tablaProductos.Keys)
                            {
                                aux = (Producto)tablaProductos[key];
                                Console.WriteLine("Codigo: {0} , Nombre: {1}, Precio: {2}, Marca: {3}", aux.Codigo, aux.Nombre, aux.Precio, aux.Marca);

                            }
                            Console.ReadKey();
                            break;
                        case "3":

                            Console.WriteLine("Ingresa el codigo del producto a eliminar:");
                            codigo = Console.ReadLine();
                            if (tablaProductos.ContainsKey(codigo))
                            {
                                tablaProductos.Remove(codigo);
                                Console.WriteLine("Producto eliminado exitosamente");
                            }
                            else
                            {
                                Console.WriteLine("No existe un producto con ese código");
                            }
                            Console.ReadKey();

                            break;
                        case "4":

                            Console.WriteLine("Ingresa el codigo del producto a buscar:");
                            codigo = Console.ReadLine();
                            if (tablaProductos.ContainsKey(codigo))
                            {
                                aux = (Producto)tablaProductos[codigo];
                                Console.WriteLine("Codigo: {0} \n Nombre: {1} \n Precio: {2} \n Marca: {3}", aux.Codigo, aux.Nombre, aux.Precio, aux.Marca);
                            }
                            else
                            {
                                Console.WriteLine("No existe un producto con ese código");
                            }
                            Console.ReadKey();
                            break;
                        case "5":
                            List<Producto> resultadoBusqueda = new List<Producto>();
                            Console.WriteLine("Ingresa el nombre del producto:");
                            string nombre = Console.ReadLine();
                            foreach (var key in tablaProductos.Keys)
                            {
                                aux = (Producto)tablaProductos[key];
                                if (aux.Nombre.ToUpper().Contains(nombre.ToUpper()))
                                {
                                    resultadoBusqueda.Add(aux);
                                }
                            }
                            if (resultadoBusqueda.Count == 0)
                            {
                                Console.WriteLine("No se encontraron resultados");

                            }
                            else
                            {
                                foreach (Producto item in resultadoBusqueda)
                                {
                                    Console.WriteLine("Codigo: {0} , Nombre: {1}, Precio: {2}, Marca: {3}", item.Codigo, item.Nombre, item.Precio, item.Marca);
                                }

                            }
                            Console.ReadKey();
                            break;
                        case "0":

                            return;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ha ocurrido un error");
                    Console.ReadKey();
                }

            }
            
            

        }
    }
}
