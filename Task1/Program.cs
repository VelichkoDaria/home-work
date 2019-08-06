using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("s= 25 ");
            float s = float.Parse(Console.ReadLine());
            double p = 4 * Math.Sqrt(s);
            Console.WriteLine("p=" + p);
        }
    }
}
