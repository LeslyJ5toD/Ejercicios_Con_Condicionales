using System;

/*Este programa en C# calcula la calificación final de un estudiante,
considerando evaluaciones normales, completivas y extraordinarias,
y determina si el estudiante aprueba o reprueba según los resultados
obtenidos en cada fase.*/

class Programa
{
    static void Main()
    {

        string mt, ne;

        Console.Write("Introduce el nombre del estudiante: ");
        ne = Console.ReadLine();

        Console.Write("Introduce el nombre de la materia: ");
        mt = Console.ReadLine();

        Console.Write("Introduce la primera nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la tercera nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la cuarta nota: ");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

        double calificacionFinal = promedio;

        string situacion = "Reprobado";

        // Evaluación Normal
        if (promedio >= 70)
        {
            situacion = "Aprobado en Evaluación Normal";
        }
        else
        {
            // Evaluación Completiva
            Console.Write("Introduce la nota de la prueba completiva: ");
            double notaCompletiva = Convert.ToDouble(Console.ReadLine());

            double promedio50 = promedio * 0.5;

            double completiva50 = notaCompletiva * 0.5;

            calificacionFinal = promedio50 + completiva50;


            if (calificacionFinal >= 70)
            {
                situacion = "Aprobado en Evaluación Completiva";
            }
            else
            {
                // Evaluación Extraordinaria
                Console.Write("Introduce la nota de la prueba extraordinaria: ");
                double notaExtraordinaria = Convert.ToDouble(Console.ReadLine());

                double promedio30 = promedio * 0.3;
                double extraordinaria70 = notaExtraordinaria * 0.7;
                calificacionFinal = promedio30 + extraordinaria70;

                if (calificacionFinal >= 70)
                {
                    situacion = "Aprobado en Evaluación Extraordinaria";
                }
            }
        }

        Console.WriteLine($"\nNombre del Estudiante: {ne}");
        Console.WriteLine($"Nombre de la Materia: {mt}");
        Console.WriteLine($"Calificación Final: {calificacionFinal:F2}");
        Console.WriteLine($"Situación: {situacion}");
    }
}
