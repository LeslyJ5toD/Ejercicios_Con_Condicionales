using System;

/*Este programa en C# compara dos números enteros 
ingresados por el usuario y muestra cuál es mayor.*/

namespace Ejercicio12concondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el primer número entero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

           
            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número = " + numero1 + " es mayor que número " + numero2 + ".");
            }
            else
            {
                Console.WriteLine("El segundo número = " + numero2 + " es mayor que número " + numero1 + ".");
            }
        }
    }
}
