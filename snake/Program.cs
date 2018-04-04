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
            p1.Draw();

            Point p2 = new Point(5, 7,'@');
           // p2.Draw();

            //lists

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);

            int l = numList[0];
            int d = numList[1];

            List<string> strList = new List<string>();
            strList.Add("first");
            strList.Add("second");

            string fir = strList[1];
            string sec = strList[1];

            //Console.WriteLine(fir);
            //Console.WriteLine(sec);

            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);

            Point p3 = new Point();
            p3 = points[1];
            p3.Draw();



            Console.ReadKey();

        }
      
    }
}
