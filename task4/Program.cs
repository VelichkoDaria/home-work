using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first number = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("sekond number = ");
            float b = float.Parse(Console.ReadLine());
            double result = Math.Sqrt(Math.Abs(a) + Math.Abs(b));
            Console.WriteLine("result =" + result);
        }
    }
}
