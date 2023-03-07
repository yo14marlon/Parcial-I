using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio.Entidades;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratorio.Entidades
{
    public class ClsVenta
    {
        Ventas ventas = new Ventas();
        public void COBRO()
        {
            Console.WriteLine("Desea comprar Peras: Escribe Si o No");

            if(Console.ReadLine() == "Si")
            {
                Console.WriteLine("El precio es " + ventas.PRECIO_DEL_PRODUCTO + "\n");
                Console.WriteLine("Cuantas peras desea comprar \n");
                int cantidad = Int32.Parse(Console.ReadLine());

                float precio_Total = cantidad * ventas.PRECIO_DEL_PRODUCTO;

                Console.WriteLine("El precio total es: $" + precio_Total);
                if(precio_Total >= 50)
                {
                    Console.WriteLine("\nTienes un descuento de $10");
                    precio_Total -= 10;
                    Console.WriteLine("El precio total es: $" + precio_Total);
                    Console.WriteLine("\nDeseas finalizar compra?: escribe Si o No");

                    if(Console.ReadLine() == "Si")
                    {
                        Console.WriteLine("Gracias por comprar...");
                    }

                    else
                    {
                        Console.WriteLine("Vuelva pronto");
                    }
                }
            }

            else
            {
                Console.WriteLine("Vuelva pronto");
            }
        }

    }
}
