using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("Mild");
                    break;
                case Season.Summer:
                    Console.WriteLine("Hot");
                    break;
                case Season.Winter:
                    Console.WriteLine("Cold");
                    break;
            }
        }
    }
}
