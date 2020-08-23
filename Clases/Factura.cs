using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOO.NewFolder
{
    public class Factura
    {
        public int ceviche, encebollado, pescado, cazuela, resultado;
        public void sumarAfactura(int cantidad, string opcion)
        {
            if(opcion == "1")
            {
                ceviche += cantidad;
                resultado += cantidad * 5;
            }
            else if(opcion == "2")
            {
                encebollado += cantidad;
                resultado += cantidad * 2;
            }
            else if (opcion == "3")
            {
                pescado += cantidad;
                resultado += cantidad * 5;
            }
            else if (opcion == "4")
            {
                cazuela += cantidad;
                resultado += cantidad * 5;
            }
        }
        public void facturaFinal()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------------------Detalles de la factura----------------------------\n");
                Console.WriteLine("Item               Precio por c/u              Cantidad                Subtotal\n");
            if (ceviche > 0)
            {
                int subtotal=0;
                subtotal += ceviche * 5;
                
                Console.WriteLine("Ceviche            $5.00                       " + ceviche+ "                       $" + subtotal);
                
            }
            if(encebollado > 0)
            {
                int subtotal = 0;
                subtotal += encebollado * 2;
                
                Console.WriteLine("Encebollado        $2.00                       " + encebollado + "                       $" + subtotal);
                
            }
            if (pescado > 0)
            {
                int subtotal = 0;
                subtotal += pescado * 5;
                
                Console.WriteLine("Pescado            $5.00                       " + pescado + "                       $" + subtotal);
                
            }
            if (cazuela > 0)
            {
                int subtotal = 0;
                subtotal += cazuela * 5;
                
                Console.WriteLine("Cazuela            $5.00                       " + cazuela + "                       $" + subtotal);
                
            }
                Console.WriteLine("\nTOTAL:                                                                 $" + resultado);
            Console.WriteLine("\n\n\nPresiona cualquier tecla para continuar...");
            /*
            ceviche = 0;
            encebollado = 0;
            pescado = 0;
            cazuela = 0;
            resultado = 0;
            */
            Console.ReadKey();

        }
    }
}
