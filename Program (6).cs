using System;
namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountGold;
            int crystalsToBuy;
            int priseCrystal = 15;

            Console.Write($"Добро пожаловать в лавку!\nCколько у вас золота: ");
            amountGold = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nЦена за один кристалл - {priseCrystal} золота.\nСколько хотите купить кристаллов?");
            crystalsToBuy = int.Parse(Console.ReadLine());
            amountGold -= crystalsToBuy * priseCrystal;
            Console.WriteLine($"\nВы купили {crystalsToBuy} кристаллов, у вас осталось {amountGold} золота.");
        }
    }
}
