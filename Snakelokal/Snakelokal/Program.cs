﻿using System;
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
            Point p1 = new Point(1,3,'0');
            p1.Drow();

            Point p2 = new Point(4,5,'1');
            p2.Drow();

            Console.ReadLine();
        }
    }
}
