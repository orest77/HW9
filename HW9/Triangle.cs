using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }

        public Triangle() { }

        public Triangle(Point a, Point b, Point c)
        {
            this.vertex1 = a;
            this.vertex2 = b;
            this.vertex3 = c;
        }
        public double Perimeter()
        {
            return Math.Round(vertex1.Distance(vertex2) + vertex2.Distance(vertex3) + vertex3.Distance(vertex1),2);
        }
        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - vertex1.Distance(vertex2)) * (p - vertex2.Distance(vertex3)) * (p - vertex3.Distance(vertex1))), 2);
        }
        public void Print()
        {
            Console.WriteLine("Triangle: {0}, {1}, {2}", vertex1, vertex2, vertex3);
            Console.WriteLine("Perimeter = {0}", Perimeter());
            Console.WriteLine("Square = {0}", Square());
        }
        
    }
}
