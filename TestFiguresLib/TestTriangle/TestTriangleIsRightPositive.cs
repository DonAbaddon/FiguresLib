using FiguresLib.Implementation.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFiguresLib.TestTriangle
{
    internal class TestTriangleIsRightPositive
    {
        [Test]
        public void TestTriangleIsRightPositive1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
        }

        [Test]
        public void TestTriangleIsRightPositive2()
        {
            Triangle triangle = new Triangle(3, 4, 5.01);
            Assert.False(triangle.IsRight());
        }

        [Test]
        public void TestTriangleIsRightPositive3()
        {
            Triangle triangle = new Triangle(6, 7, 8);
            Assert.False(triangle.IsRight());
        }

        [Test]
        public void TestTriangleIsRightPositive4()
        {
            Triangle triangle = new Triangle(18, 38.5, 42.5);
            Assert.True(triangle.IsRight());
        }

        [Test]
        public void TestTriangleIsRightPositive5()
        {
            Triangle triangle = new Triangle(14, 48, 50);
            Assert.True(triangle.IsRight());
        }
    }
}
