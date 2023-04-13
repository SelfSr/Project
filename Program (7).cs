using System;


namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountPeople;
            int timeWaitMinutes;
            int timeWaitHour;
            int timeForPersonInMinutes = 10;
            int minutesInHour = 60;

            Console.Write("Введите количество людей перед вами: ");
            amountPeople = int.Parse(Console.ReadLine());

            timeWaitMinutes = amountPeople * timeForPersonInMinutes % minutesInHour;
            timeWaitHour = amountPeople * timeForPersonInMinutes / minutesInHour;

            if (timeWaitHour == 0)
                Console.WriteLine($"Вы должны отстоять в очереди {timeWaitMinutes} м..");
            else if (timeWaitMinutes == 0)
                Console.WriteLine($"Вы должны отстоять в очереди {timeWaitHour} ч.");
            else
                Console.WriteLine($"Вы должны отстоять в очереди {timeWaitHour} ч. и {timeWaitMinutes} м.");
        }
    }
}
