using FiguresLib.Implementation.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFiguresLib.TestCircle
{
    internal class TestCircleSquarePositive
    {
        [Test]
        public void TestCircleSquarePositive1()
        {
            double radius = 5;
            double expectedSquare = 78.5398163397;
            Circle circle = new Circle(radius);
            Assert.That(circle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestCircleSquarePositive2()
        {
            double radius = 3;
            double expectedSquare = 28.2743338823;
            Circle circle = new Circle(radius);
            Assert.That(circle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestCircleSquarePositive3()
        {
            double radius = 0;
            double expectedSquare = 0;
            Circle circle = new Circle(radius);
            Assert.That(circle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestCircleSquarePositive4()
        {
            double radius = 0.003;
            double expectedSquare = 0.0000282743338823;
            Circle circle = new Circle(radius);
            Assert.That(circle.Square(), Is.EqualTo(expectedSquare).Within(0.000001));
        }

        [Test]
        public void TestCircleSquarePositive5()
        {
            double radius = 1234.5678;
            double expectedSquare = 4788282.48494;
            Circle circle = new Circle(radius);
            Assert.That(circle.Square(), Is.EqualTo(expectedSquare).Within(0.00001));
        }
    }
}
