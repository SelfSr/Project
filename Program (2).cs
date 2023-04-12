using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, zodiacSing, workPlace, ageWord;
            int age;

            Console.Write("Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Какой ваш знак зодиака: ");
            zodiacSing = Console.ReadLine();
            Console.Write("Ваше место работы: ");
            workPlace = Console.ReadLine();

            ageWord = ChooseWordAge(age);

            Console.WriteLine($"\nВас зовут {name}, вам {age} {ageWord}, вы {zodiacSing} и ваше место работы: {workPlace}");
        }
        public static string ChooseWordAge(int count)
        {
            if (count % 10 == 1 && count % 100 != 11)
                return "год";
            else if (count % 10 >= 2 && count % 10 <= 4)
                return "года";
            else
                return "лет";
        }
    }
}
