using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first number a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("sekond number b = ");
            float b = float.Parse(Console.ReadLine());
            double s = (a*b)/2;
            Console.WriteLine("s =" + s);
        }
    }
}
