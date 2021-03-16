using System;

namespace Prueba
{
    class Program
    {
        public static void Main(string[] args)
        {

            int a = 0, b = 0;

            Console.Write("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Subtracting {a} - {b} equals {subst(a, b)}");
        }

        public static int subst(int a, int b)
        {
            return a - b;
        }
    }
}