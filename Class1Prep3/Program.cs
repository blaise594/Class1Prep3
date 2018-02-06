using System;

namespace Class1Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many miles have you driven? ");
            string miles = Console.ReadLine();
            float mi = Convert.ToInt32(miles);

            Console.Write("How many gallons of gas have you consumed? ");
            string gallons = Console.ReadLine();
            float gal = Convert.ToInt32(gallons);

            float mpg = mi / gal;
            Console.WriteLine("Your fuel efficiency is " + mpg + " mpg");

            Console.ReadLine();
        }
    }
}
