using System;
using System.Globalization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, resultado;

            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = X / Y;

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            //Console.ReadLine();
        }
    }
}


