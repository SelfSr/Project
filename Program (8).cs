using System;
using System.Globalization;

namespace Projecks
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество rub");
            double a = double.Parse(Console.ReadLine());

            double converts = a * 0.015982;
            double converts1 = a * 0.59022;
            Console.WriteLine("Вы получите " + Math.Round(converts, 2) + "$");
            Console.WriteLine("Вы получите " + Math.Round(converts1, 2) + " ua");


        }

    }
}
