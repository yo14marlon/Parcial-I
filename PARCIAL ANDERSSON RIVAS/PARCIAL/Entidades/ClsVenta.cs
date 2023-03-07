using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace Parcial.Entidades
{
    public class ClsVenta
    {
        Ventas ventas = new Ventas();
        public void COBRO()
        {
            Console.WriteLine("desea comprar fresas: Escribe si o no");

            if(Console.ReadLine() == "si")
            {
                Console.WriteLine("el precio es " + ventas.PRECIO_DEL_PRODUCTO + "\n");
                Console.WriteLine("Cuantas fresas desea comprar \n");
                int cantidad = Int32.Parse(Console.ReadLine());

                float precio_Total = cantidad * ventas.PRECIO_DEL_PRODUCTO;

                Console.WriteLine("su precio total es: $" + precio_Total);
                if(precio_Total >= 30)
                {
                    Console.WriteLine("\nTiene un descuento de $10");
                    precio_Total -= 10;
                    Console.WriteLine("Su precio total es: $" + precio_Total);
                    Console.WriteLine("\ndesea finalizar compra?: escribe si o no");

                    if(Console.ReadLine() == "si")
                    {
                        Console.WriteLine("gracias por su compra..");
                    }

                    else
                    {
                        Console.WriteLine("vuelve pronto");
                    }
                }
            }

            else
            {
                Console.WriteLine("vuelve pronto");
            }
        }

    }
}
