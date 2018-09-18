using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW9;
using System.Linq;
using System.IO;

namespace PointTests
{
    [TestClass]
    public class Points
    {
        [TestMethod]
        public void DistancePoints()
        {
            //Arrange
            Point p1 = new Point(1,2);
            Point p2 = new Point(3,4);
            double expected = 2.8284271247461903;

            //Act
            double result = p1.Distance(p2);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void NegativeСharacters()
        {
            //Arrange
            Point p1 = new Point(-4, -8);
            Point p2 = new Point(-2, -7);
            double expected = 2.23606797749979;

            //Act
            double result = p1.Distance(p2);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void String()
        {
            //Arrange
            Point p = new Point(1, 1);
            string expected = " " + 1 + " " + 1 + " ";

            //Act
            string result = p.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PerimeterTestTriangle()
        {
            //Arrange
            Point a = new Point(-2, 2);
            Point b = new Point(3, 3);
            Point c = new Point(5, -2);
            Triangle triangle = new Triangle(a, b, c);
            double exepted = 18.55;
            //Act
            double result = triangle.Perimeter();

            //Assert
            Assert.AreEqual(result, exepted);
        }

        [TestMethod]
        public void SquareTestTriangle()
        {
            //Arrange
            Point a = new Point(4, 1);
            Point b = new Point(2, 1);
            Point c = new Point(10, 2);
            Triangle triangle = new Triangle(a, b, c);
            double expected = 1.12;
            //Act
            double result = triangle.Square();
            //Assert
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void PrintTestTriangle()
        {
            //Arrange
            Triangle trianle = new Triangle(new Point(2, 3), new Point(2, 1), new Point(3, 7));
            string expected = "Triangle: 2 3 , 2 1 , 3 7" +
                "Perimeter = 12,21" +
                "Square = 1,05";

            //Act
            string result;

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                trianle.Print();
                result = stringWriter.ToString();
            }

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
    

}
