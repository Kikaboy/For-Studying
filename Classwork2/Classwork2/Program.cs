using System;

namespace Classwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Input("n");
            Console.WriteLine("Значение выражения" + F(n));
            Console.ReadKey();

        }
        static bool F(double n)
        {
            return (n % 4 == 0 & n%10!=0);

        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите число " + Name);
            return double.Parse(Console.ReadLine());
        }
    }
}
