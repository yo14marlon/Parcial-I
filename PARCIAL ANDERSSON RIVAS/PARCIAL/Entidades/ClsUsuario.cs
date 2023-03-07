using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Parcial.Entidades;

namespace Parcial.Entidades
{
    public class ClsUsuario
    {
        Usuario usuario = new Usuario();
        
        public bool ACCESO()
        {
            Console.WriteLine("Ingrese su nombre de usuario: ");
            string? nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese su contraseña: ");
            string? contraseña = Console.ReadLine();
            

            if(nombre == usuario.Nombre && contraseña == usuario.Contra)
            {
                return true;
            }

            else
            {
                while(nombre != usuario.Nombre && contraseña != usuario.Contra)
                {
                    Console.WriteLine("Los datos si son incorrectos: ");
                    Console.WriteLine("\nIngrese su nombre de usuario: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("\nIngrese su contraseña: ");
                    contraseña = Console.ReadLine();
                }
                return true;
            }
        }
    }
}
