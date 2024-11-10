using System;

namespace Ejercicio13concondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el primer número entero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Introduce el segundo número entero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduce el tercer número entero:");
            int numero3 = Convert.ToInt32(Console.ReadLine());


            if (numero1 > numero2 && numero1 > numero3 )
            {
                Console.WriteLine("El primer número ingresado = " + numero1 + " es mayor que " + numero2 + " y " + numero3 + ".");
            }
            else if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("El segundo número ingresado = " + numero2 + " es mayor que " + numero1 + " y " + numero3 + ".");
            }
            else
            {
                Console.WriteLine("El tercer número ingresado = " + numero3 + " es mayor que " + numero1 + " y " + numero2 + ".");
            }
        }
    }
}
    