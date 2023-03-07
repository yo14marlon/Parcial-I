using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Laboratorio.Entidades;

namespace Laboratorio.Entidades
{
    public class ClsUsuario
    {
        Usuario usuario = new Usuario();
        
        public bool ACCESO()
        {
            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string? nombre = Console.ReadLine();
            Console.WriteLine("\nIngresa tu contraseña: ");
            string? contraseña = Console.ReadLine();
            

            if(nombre == usuario.Nombre && contraseña == usuario.Contra)
            {
                return true;
            }

            else
            {
                while(nombre != usuario.Nombre && contraseña != usuario.Contra)
                {
                    Console.WriteLine("Los datos son incorrectos: ");
                    Console.WriteLine("\nIngresa tu nombre de usuario: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("\nIngresa tu contraseña: ");
                    contraseña = Console.ReadLine();
                }
                return true;
            }
        }
    }
}
