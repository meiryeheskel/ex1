// Show the difference between 2 characters

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter first character:");
            int first = (int)(char.Parse(Console.ReadLine()));
            Console.WriteLine("Please Enter second character:");
            int second = (int)(Char.Parse(Console.ReadLine()));

            Console.WriteLine($"The difference between the 2 characters is: {Math.Abs(first - second)}");



        }
    }

}
