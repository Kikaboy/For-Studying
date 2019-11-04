using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну первой стороны ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длинну второй стороны");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение угла");
            double angle = double.Parse(Console.ReadLine());
            double square = ((first * second) / 2) * Math.Sin(angle);
            Console.WriteLine("Площадь треугольника равна:", square);
            Console.ReadKey();
        }
    }
}
