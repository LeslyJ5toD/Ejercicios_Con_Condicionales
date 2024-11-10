using System;


namespace Ejercicio4concondicion
{
    internal class Ejercicio4ConCondicion
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

            // Calcular el promedio
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

           
            Console.WriteLine("Promedio de las calificaciones: " + promedio);

            string situacion;


            if (promedio >= 90 && promedio <= 100)
            {
                situacion = "Excelente";
            }
            else if (promedio >= 80 && promedio < 90)
            {
                situacion = "Muy Bueno";
            }
            else if (promedio >= 75 && promedio < 80)
            {
                situacion = "Bueno";
            }
            else if (promedio >= 70 && promedio < 75)
            {
                situacion = "Regular";
            }
            else
            {
                situacion = "Deficiente";
            }

            Console.WriteLine("La situación del estudiante es: " + situacion);
        }
    }
}