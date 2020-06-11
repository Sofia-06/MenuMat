using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMatri
{
    class Program
    {
        /*
        *            Nombre[0]     apellido[1]      direccion[2]      telefono[3]
        *  con[0]
        *  con[2]
        *  con[3]
        */
        static String[,] menu = new string[4, 10];
        static void Main(string[] args)
        {
            string usuario = "Contacto no encontrado";
            string buscar = "";
            string buscar2 = "";
            int num;
            do
            {
                Console.WriteLine("Bienvenido, seleccione la opcion que desee: ");
                Console.WriteLine(" 1. Crear contactos: ");
                Console.WriteLine(" 2. Mostrar contactos: ");
                Console.WriteLine(" 3. Buscar contacto deseado: ");
                Console.WriteLine(" 4. Salir: ");
                Console.WriteLine("Ingrese la opción deseada:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (num == 1)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        Console.WriteLine("Ingrese nombre: ");
                        menu[0, f] = Console.ReadLine();

                        Console.WriteLine("Ingrese Apellido: ");
                        menu[1, f] = Console.ReadLine();

                        Console.WriteLine("Ingrese Dirección: ");
                        menu[2, f] = Console.ReadLine();

                        Console.WriteLine("Ingrese Teléfono: ");
                        menu[3, f] = Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (num == 2)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        Console.WriteLine(menu[0, f] + "--" + menu[1, f] + "--" + menu[2, f] + "--" + menu[3, f]);
                    }
                    Console.ReadLine();
                    num = 1;
                    Console.Clear();
                }

                else if (num == 3)
                    {
                    Console.Write("Ingrese el nombre del contacto que desea buscar: ");
                    buscar = Console.ReadLine();
                    Console.Write("Ingrese el apellido: ");
                    buscar2 = Console.ReadLine();
                    for (int f = 0; f < 10; f++)
                    {
                        if (buscar == menu[0, f] && buscar2 == menu[1, f])
                        {
                            usuario = menu[0, f] + "--" + menu[1, f] + "--" + menu[2, f] + "--" + menu[3, f];
                        }
                    }
                    Console.WriteLine(usuario);
                    Console.ReadLine();
                    num = 1;
                    Console.Clear();
                }
                else if (num == 4)
                {
                    Environment.Exit(0);
                }
            } while (num == 1);
            
            Console.ReadKey();
        }
    }
}
