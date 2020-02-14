using System;

namespace labexercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a number to check either even or odd");

            num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadLine();
        }
    }
}
