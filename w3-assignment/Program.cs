using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_assignment
{
    class Program
    {

        static void GetRandomPoint(ref Point p)
        {
            Random r = new Random();
            p.X = r.Next(0, 100);
            p.Y = r.Next(0, 100);
        }

        static void Main(string[] args)
        {
        
            //define point structure
            struct Point
            {
                public int X;
                public int Y;

                public Point(int x, int y)
                {

                    X = x;
                    Y = y;

                }

            }

            //create a point object

            Point p1 = new Point(10, 20);

        }
    }
}
            