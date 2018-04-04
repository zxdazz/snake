using System;
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
            Point p1 = new Point(3,5,'#');
           // p1.Draw();

            Point p2 = new Point(5, 7,'@');
           // p2.Draw();

            //create horizont line

            HorizontalLine hline = new HorizontalLine(0, 50, 1, '+');
            hline.Drow();

            //create vertical line

            VerticalLine vline = new VerticalLine(25, 1, 25, '+');
            vline.Drow();


            Console.ReadKey();

        }
      
    }
}
