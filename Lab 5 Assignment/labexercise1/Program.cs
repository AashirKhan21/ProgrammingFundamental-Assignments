using System;

namespace labexercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter any year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year = " + year);
            }
            Console.ReadLine();
        }
    }
}
