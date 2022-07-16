using System;
using System.Linq;

namespace T05Ejercicio12
{
    class Program
    {
        static void Main()
        {
            double[] array = new double[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Añada el " + (i + 1) + "º valor: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                array[i] = valor;
            }
            //Utilizo el método Average de System.Linq Namespace para el promedio
            Console.WriteLine("La media de todos los valores es: " + array.Average());

        }
    }
}