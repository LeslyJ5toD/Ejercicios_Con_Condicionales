using System;

/*Este programa en C# calcula el sueldo neto de un empleado,
considerando los descuentos de AFP, SFS e ISR. Solicita el 
sueldo bruto mensual, calcula los descuentos correspondientes 
y, si es necesario, calcula el ISR según los tramos fiscales. 
Luego, muestra el sueldo bruto, los descuentos y el sueldo neto.*/

namespace Ejercicio11concondicion
{
    internal class Ejercicio11concondicion
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese el sueldo bruto mensual del empleado:");
            double sueldoBruto = Convert.ToDouble(Console.ReadLine());

            // Descuentos
            double AFP = sueldoBruto * 0.0287;
            double SFS = sueldoBruto * 0.0304;

            
            double sueldoDespuesAFPSFS = sueldoBruto - AFP - SFS;

            double ISR = Convert.ToDouble(sueldoDespuesAFPSFS);

            
            if (ISR == 0)
            {
                Console.WriteLine("ISR: N/A");
            }

            double sueldoNeto = sueldoDespuesAFPSFS - ISR;

           
            Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
            Console.WriteLine("Descuento AFP: " +  AFP);
            Console.WriteLine("Descuento SFS: " +  SFS);
            Console.WriteLine("ISR: " + (ISR == 0 ? "N/A" : " + ISR.ToString"));
            Console.WriteLine("Sueldo Neto: " + sueldoNeto);
        }

        static double CalcularISR(double ISR)
        {

            if (ISR <= 416220)
            {
                return 0;
            }
            else if (ISR <= 624329)
            {
                return (ISR - 416220) * 0.15;
            }
            else if (ISR <= 867123)
            {
                return (ISR - 624329) * 0.20 + 31216;
            }
            else if
            {
                return (ISR - 867123) * 0.25 + 79776;
            }
            else (ISR == 0 ?);
                    
                    Console.WriteLine("N/A") ;
        }
    }
}

