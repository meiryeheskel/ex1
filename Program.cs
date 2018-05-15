// Show the difference between 2 characters

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter first character: ");
            int first = Char.Parse(Console.ReadLine());
            Console.Write("Please Enter second character: ");
            int second = Char.Parse(Console.ReadLine());

            Console.WriteLine($"The difference between the 2 characters is: {Math.Abs(first - second)}");



        }
    }

}
