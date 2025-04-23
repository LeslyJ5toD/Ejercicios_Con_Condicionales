using System;

/*Este programa en C# solicita el sexo y la edad 
de una persona para determinar si puede entrar a 
una discoteca: si es menor de 18, no puede entrar;
si es mayor de edad, las chicas entran gratis y los 
chicos pagan.*/

class Program
{
    static void Main()
    {

        Console.Write("Ingrese el sexo de la persona : ");
        string sexo = Console.ReadLine();

        if (sexo == "chica")
            Console.WriteLine("Ingrese su edad:");

       else if (sexo == "chico")
            Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("No puede entrar a la discoteca.");
        }
        else if (sexo == "chica")
        {
            Console.WriteLine("Puede entrar gratis a la discoteca.");
        }
        else if(sexo == "chico")
        {
            Console.WriteLine("Puede entrar pagando a la discoteca.");
        }
        
    }
}
