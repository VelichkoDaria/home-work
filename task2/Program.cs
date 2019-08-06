using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("p=");
            float p = float.Parse(Console.ReadLine());
            double a  = p / 3 ;
            double s = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);

            Console.WriteLine("s=" + s);
            Console.ReadKey();
        }
    }
}
