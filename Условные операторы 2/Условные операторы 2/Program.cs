using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_операторы_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                    Console.WriteLine("Введите символ");
                char x = char.Parse(Console.ReadLine());
                if (char.IsDigit(x))
                    Console.WriteLine("Это цифра");
                if (char.IsLower(x))
                    Console.WriteLine("Это строчная буква");
                if (char.IsUpper(x))
                    Console.WriteLine("Это заглавная буква");
                if (char.IsPunctuation(x))
                    Console.WriteLine("Это знак пунктуации");
                if (char.IsWhiteSpace(x))
                    Console.WriteLine("Это пробел");
                Console.ReadKey();
            }
        }
    }
}
