using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakelokal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symb = '$';
            Drow(x1, y1, symb);

            int x2 = 4;
            int y2 = 6;
            char symb2 = '#';
            Drow(x2, y2, symb2);


            Console.ReadLine();
        }

        static void Drow(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
