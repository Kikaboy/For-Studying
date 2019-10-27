using System;
using System.Text;

namespace Homework2._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("White Queen Start");
            var poswhite = Console.ReadLine().ToLower();
            Console.WriteLine("Black Bishop Start");
            var posblack = Console.ReadLine().ToLower();
            Console.WriteLine("Is Queen Can Move ?");
            var movewhite = Console.ReadLine().ToLower();
            Console.WriteLine("Able To Move?, {0}", MoveQueen(poswhite, movewhite), MoveBishop(posblack, movewhite));
            Console.ReadKey();
        }
        static void Decoding(string position,
            out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = (int)position[1] - 0x30;

        }
        static bool MoveQueen(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;
            Decoding(start, out startColumn, out startRow);
            Decoding(end, out endColumn, out endRow);
            return startColumn == endColumn || startRow == endRow || Math.Abs(startColumn - endColumn) == Math.Abs(startRow - endRow);
        }
        static bool MoveBishop(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;
            Decoding(start, out startColumn, out startRow);
            Decoding(end, out endColumn, out endRow);
            return Math.Abs(startColumn - endColumn) == Math.Abs(startRow - endRow);
        }
    }
}
