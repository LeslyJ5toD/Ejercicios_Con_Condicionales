using System;


namespace Ejerciciodegamacondicion2
{
    internal class Ejercicio2conCondicion
    {

        /*Crear un programa que introduzca el precio de un articulo y aplique un descuento 
        con la siguiente escala: 
        Escala                       Porcentaje
        De 1,000 a 5,000             3% 
        De 5,001 a 10,000            5%  
        De 10,001 a 15,000           8% 
        De 15,001 a 20,000           10%
        Mostrar en pantalla el precio del artículo, y el descuento.*/

        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el precio del articulo: ");
            double precio = Convert.ToDouble(Console.ReadLine());


            double descuentoPorcentaje = 0;

            if (precio >= 1000 && precio <= 5000)
            {
                descuentoPorcentaje = 0.03; // 3%
            }
            else if (precio >= 5001 && precio <= 10000)
            {
                descuentoPorcentaje = 0.05; // 5%
            }
            else if (precio >= 10001 && precio <= 15000)
            {
                descuentoPorcentaje = 0.08; // 8%
            }
            else if (precio >= 15001 && precio <= 20000)
            {
                descuentoPorcentaje = 0.010; // 10%
            }
            else
            {
                Console.WriteLine("No se aplica descuento para precios fuera del rango especificado.");
                return;
            }

            double descuento = precio * descuentoPorcentaje;

            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Descuento : " + descuento);
            Console.WriteLine("Porcentaje : " + descuentoPorcentaje);

        }
    }





}

