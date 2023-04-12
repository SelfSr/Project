using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiacSing;
            string workPlace;
            string age;

            Console.Write("Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Console.ReadLine();
            Console.Write("Какой ваш знак зодиака: ");
            zodiacSing = Console.ReadLine();
            Console.Write("Ваше место работы: ");
            workPlace = Console.ReadLine();

            Console.WriteLine($"\nВас зовут {name}, вам {age}, вы {zodiacSing} и ваше место работы: {workPlace}");
        }
    }
}
