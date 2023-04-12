using System;


namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Белочкин";
            string lastName = "Алексей";
            string tempString;

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}");

            tempString = firstName;
            firstName = lastName;
            lastName = tempString;

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}");
        }
    }
}
