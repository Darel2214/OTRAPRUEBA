using ProyectoPOO.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO.Clases
{
    
    class Detalles
    {
        public static NewFolder.Factura nuevafactura = new NewFolder.Factura();
        public static void Menu(string opcion)
        {
            
            if (opcion == "1")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ha comprado " + cantidad+" ceviches.\n");
            do
            {
                    Console.WriteLine("Escriba el número de la opción que desea elejir" +
                    "\n1. Seguir comprando."+
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                        nuevafactura.facturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada ("+opciones+") no existe, por favor, intente nuevamente.\n");
                    }
            } while (opciones > 2 || opciones <1);
        }
            else if (opcion == "2")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ha comprado " + cantidad + " encebollados.\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opción que desea elejir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                        nuevafactura.facturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
            else if (opcion == "3")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ha comprado " + cantidad + " pescados.\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opción que desea elejir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                        nuevafactura.facturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
            else if (opcion == "4")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ha comprado " + cantidad + " cazuelas.\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opción que desea elejir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.sumarAfactura(cantidad, opcion);
                        nuevafactura.facturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }



        }
    }

}

