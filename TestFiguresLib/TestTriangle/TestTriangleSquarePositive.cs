using FiguresLib.Implementation.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFiguresLib.TestTriangle
{
    internal class TestTriangleSquarePositive
    {
        [Test]
        public void TestTriangleSquarePositive1()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedSquare = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestTriangleSquarePositive2()
        {
            double sideA = 4;
            double sideB = 4;
            double sideC = 0;
            double expectedSquare = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestTriangleSquarePositive3()
        {
            double sideA = 5.5;
            double sideB = 5.5;
            double sideC = 5.5;
            double expectedSquare = 13.0986342322;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestTriangleSquarePositive4()
        {
            double sideA = 9.6;
            double sideB = 2.3;
            double sideC = 8.6;
            double expectedSquare = 9.34854768132;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestTriangleSquarePositive5()
        {
            double sideA = 90.6;
            double sideB = 71.5;
            double sideC = 83;
            double expectedSquare = 2811.66261365;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }
    }
}
