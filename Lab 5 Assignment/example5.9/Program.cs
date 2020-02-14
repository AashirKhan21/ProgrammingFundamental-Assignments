using System;

namespace example5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15, b = 10, c = 1;
            if (Convert.ToBoolean(a) && (b>c))
            {
                Console.WriteLine("cquestion");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
