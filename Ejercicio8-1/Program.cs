using System;

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
