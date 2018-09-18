using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Abs(Math.Pow(this.x - p.x, 2)) + Math.Abs(Math.Pow(this.y - p.y, 2)));
        }

        public override string ToString()
        {
            return " "+ x +" " + y +" ";
        }

    }
}
