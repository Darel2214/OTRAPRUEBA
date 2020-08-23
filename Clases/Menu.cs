using ProyectoPOO.Clases;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoPOO.NewFolder
{
    class Menu
    {
        Clases.Detalles detalles = new Clases.Detalles();
        public static NewFolder.Factura nuevafactura = new NewFolder.Factura();
        public string opciones;
        public void Enlistar()
        {
            opciones="0";
            
            do
            {
                Console.Clear();
                Console.WriteLine("================================================\n\n" + 
                "                  Menú del día:\n\n================================================\n"+
                "Digite el número de la opción que desea  elegir:\n" +
                "\n1.- Ceviche" +
                "\n2.- Encebollado" +
                "\n3.- Pescado apanado" +
                "\n4.- Cazuela" +
                "\n5.- Mostrar factura." +
                "\n0.- Salir\n");
                opciones = Console.ReadLine();
                switch(opciones)

                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("El Valor del ceviche es de $5.00");
                        Detalles.Menu(opciones);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("El Valor del Encebollado es de $2.00");
                        Detalles.Menu(opciones);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("El valor del Pescado apanado es de $5.00");
                        Detalles.Menu(opciones);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("El valor de la cazuela es de de $5.00");
                        Detalles.Menu(opciones);
                        break;
                    case "5":
                        Console.WriteLine("Mostrar factura.");
                        Detalles.nuevafactura.facturaFinal();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Su pedido a sido Cancelado");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Este Dato esta Incorrecto, Vuelva a intentarlo");
                        Console.ReadKey();
                        break;
                }

            }while(opciones != "0");   
        }

    }
}
