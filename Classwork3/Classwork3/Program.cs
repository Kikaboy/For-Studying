using System;

namespace Classwork3
{
    class Program
    {
        static void Main(string[] args)
        {
           var x = Input("x");
           var y = Input("y");
            Console.WriteLine("Координаты:" + Coordinates(x,y));
            Console.ReadKey();
        }
        static bool Coordinates(double x, double y)
        {
            bool v = (y > -0.5 & y < 2);
            return (x > -1 & x < 1.5) & v;
        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите значение " + Name);
            return double.Parse(Console.ReadLine());
        }

    }
}
