using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangle = new List<Triangle>();

            triangle.Add(new Triangle(new Point(2, 3), new Point(2, 1), new Point(3, 7)));
            triangle.Add(new Triangle(new Point(2, 3), new Point(0, 2), new Point(3, -5)));
            triangle.Add(new Triangle(new Point(4, 1), new Point(2, 1), new Point(10, 2)));

            foreach (var triangl in triangle)
            {
                triangl.Print();
            }

            Console.WriteLine("______________");
            
            triangle.OrderBy(x => x.Vertex1.Distance(new Point(0, 0)))
                             .ThenBy(x => x.Vertex2.Distance(new Point(0, 0)))
                             .ThenBy(x => x.Vertex3.Distance(new Point(0, 0))).First().Print();

            Console.ReadKey();
        }
    }
}
