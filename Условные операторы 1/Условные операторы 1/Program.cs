using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_операторы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите координаты x=");
                int x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введите координаты y=");
                int y = Convert.ToInt16(Console.ReadLine());

                if ((x > 0) && (y > 0))
                    Console.Write("Точка в первой координатной четверти" + "\n");
                if ((x < 0) && (y > 0))
                    Console.Write("Точка во второй координатной четверти" + "\n");
                if ((x < 0) && (y < 0))
                    Console.Write("Точка в третьей координатной четверти" + "\n");
                if ((x > 0) && (y < 0))
                    Console.Write("Точка в четвертой координатной четверти" + "\n");
                if ((x == 0) && ((y > 0) || (y < 0)))
                    Console.WriteLine("Точка совпадает с началом оси х" + "\n");
                if ((y == 0) && ((x > 0) || (x < 0)))
                    Console.WriteLine("Точка совпадает с началом оси y" + "\n");
                
            }
        }
    }
}
