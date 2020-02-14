using System;

namespace example5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b = -1;
            if (Convert.ToBoolean(++a = ++b))
            {
                Console.WriteLine("a");
            }
            else
            {
                Console.WriteLine("b");
            }
        }
    }
}
