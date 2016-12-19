using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakelokal
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        //конструктор класса, конструкторов может быть несколько
        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public void Drow()
        {
            Console.SetCursorPosition( x, y );
            Console.Write( symb );
        }
    }
}
