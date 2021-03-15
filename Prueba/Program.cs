using System;

namespace Prueba
{
    class Program
    {
        public static void Main(string[] args)
        {

            int a = 0, b=0;

            Console.Write("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals {sum(a,b)}");
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
