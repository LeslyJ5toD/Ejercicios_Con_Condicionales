using System;

/*Este programa en C# verifica si un número
entero ingresado por el usuario es par o impar.*/

namespace Ejercicio11_6concondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Introduce un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

           
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }
        }
    }
}
    
