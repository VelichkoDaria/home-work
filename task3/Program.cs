using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first number = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("sekond number = ");
            float b = float.Parse(Console.ReadLine());
            double result = (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2;
            Console.WriteLine("result =" + result);
        }
    }
}
