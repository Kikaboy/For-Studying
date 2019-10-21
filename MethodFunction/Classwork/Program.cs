using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = F(3, 2) + F(5, 3) + F(7, 4);
            Console.WriteLine("x={0:F3}", x);
            Console.ReadKey();
        }
        static double F(double x, double y)
        {
          return Math.Log(x + Math.Pow(y, x)) / Math.Log(y + Math.Pow(x, y));
           
        }
    }
}
