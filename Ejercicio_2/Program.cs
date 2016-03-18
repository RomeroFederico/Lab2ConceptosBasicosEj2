using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{

    /*
    02.  Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se
    debe validar que el número sea mayor que cero, caso contrario, 
    mostrar el mensaje: "ERROR. Reingresar número!!!". 
 
    Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la
    operación.
    */

    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            Console.Title = "Ejercicio Nro. 2";

            Console.Write("Ingrese un numero mayor a 0: ");

            do
            {
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Clear();
                    Console.Write("Error!!! No se ingreso un numero. Ingrese un numero mayor a 0: ");
                }
                if (numero <= 0)
                {
                    Console.Clear();
                    Console.Write("ERROR. Reingresar número!!! ");
                }
            } while (numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.Clear();
            Console.Write("El cuadrado de {0,0:#,###.00} es {1,0:#,###.00}, y al cubo es {2,0:#,###.00}. ", numero, cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
