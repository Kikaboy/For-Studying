using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_операторы_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите значени х");
                var x = int.Parse(Console.ReadLine());
                if (Math.Sin(x) < 0)
                {
                    var y = (-Math.Cos(x));
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
                if (Math.Sin(x) > 0)
                {
                    var y = Math.Cos(x);
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
                if (x == 0)
                {
                    var y = (Math.Sin(x) / Math.PI);
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
            }
        }
    }
}
