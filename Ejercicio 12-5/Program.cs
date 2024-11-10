using System;


namespace Ejercicio10concondicion
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Introduce un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            
            if (numero > 0)
            {
                Console.WriteLine("El número " + numero + " es positivo."); 
            }
            else
            {
                Console.WriteLine("El número " + numero + " es negativo.");
            }
        }
    }
}
   
