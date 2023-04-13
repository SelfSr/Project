using System;


namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = 52;
            int PicturesInRow = 3;

            int filledRows = totalPictures / PicturesInRow;
            int leftPictures = totalPictures % PicturesInRow;

            Console.WriteLine($"Количество полностью заполненых рядов - {filledRows}, оставшиеся картинки - {leftPictures}");
        }
    }
}
