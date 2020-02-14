using System;

namespace labexercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A = " +a);
            Console.WriteLine("B = " +b);
            Console.WriteLine("C = " +c);

            if (a+b+c == 180)
            {
                Console.WriteLine("Triangle is valid");
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
            }
            Console.ReadLine();
        }
    }
}
