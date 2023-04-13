using System;
namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = 52;
            int picturesInRow = 3;
            
            int filledRows = totalPictures / picturesInRow;
            int leftPictures = totalPictures % picturesInRow;
            Console.WriteLine($"Количество полностью заполненых рядов - {filledRows}, оставшиеся картинки - {leftPictures}");
        }
    }
}
