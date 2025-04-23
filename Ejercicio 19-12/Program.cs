using System;

/*Este programa en C# calcula un incentivo para un empleado basado
en el número de hijos que tiene. Solicita el sueldo y el número de 
hijos del empleado, y si el empleado tiene hijos, le asigna un incentivo
de 500 por cada hijo. Luego, muestra el sueldo, el número de hijos y el 
incentivo calculado.*/

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
