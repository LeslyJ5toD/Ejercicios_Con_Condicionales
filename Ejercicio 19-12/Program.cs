using System;

class Programa
{
    static void Main()
    {
        Console.Write("Introduce el sueldo del empleado: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el número de hijos del empleado: ");
        int numeroHijos = Convert.ToInt32(Console.ReadLine());

        double incentivo = 0;

        if (numeroHijos > 0)
        {
            incentivo = numeroHijos * 500;
        }

        Console.WriteLine($"\nSueldo del empleado: {sueldo:C}");
        Console.WriteLine($"Número de hijos: {numeroHijos}");
        Console.WriteLine($"Incentivo: {incentivo:C}");
    }
}
