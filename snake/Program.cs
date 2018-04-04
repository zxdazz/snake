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
            /*p1.x = 3;
            p1.y = 5;
            p1.sym = '*'; */
            p1.Draw();


            Point p2 = new Point(5, 7,'@');
            /*p2.x = 6;
            p2.y = 8;
            p2.sym = '#';*/

            p2.Draw();


            Console.ReadKey();

        }
      
    }
}
