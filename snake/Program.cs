﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 5;
            char sym1 = '@';

            Draw(x1, y1, sym1);

            int x2 = 6;
            int y2 = 3;
            char sym2 = '#';

            Draw(x2, y2, sym2);


            Console.ReadKey();

        }
        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
