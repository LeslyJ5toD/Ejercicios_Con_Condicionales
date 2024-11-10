using System;

namespace Ejercicio3degamaconcondicion
{
    internal class Condicion3
    {
        static void Main(string[] args)
        {

            
            double nota1, nota2, nota3, nota4, promedio;


            Console.Write("Ingresa la nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la nota 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

           
            Console.WriteLine("Promedio de las calificaciones: " + promedio);

            // Determinar si aprobó o reprobó
            if (promedio >= 70)
            {
                Console.WriteLine("El estudiante aprobó.");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó.");
            }
        }
    }
}
    