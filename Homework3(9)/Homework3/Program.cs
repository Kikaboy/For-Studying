using System;

namespace Main1
{
    class Main1
    {
        static void Main()
        {
            Console.WriteLine("Введите значение Х");
            double X = double.Parse(Console.ReadLine());
            double Y = (Math.Abs(1 + Math.Sqrt(X + 1) / (Math.Abs(1 - Math.Sqrt(X - 1)))));
            Console.WriteLine("У = {0}", Y);
            Console.ReadKey();

        }
    }
}
