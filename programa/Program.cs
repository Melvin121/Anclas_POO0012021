using System;

namespace github
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adding {a} * {b} equals {AddNumbers(a, b)}")
        }
        public static int AddNumbers( int a, int b)
        {
            return a * b;
        }
    }
}