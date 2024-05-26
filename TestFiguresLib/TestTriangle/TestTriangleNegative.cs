using FiguresLib.Implementation.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFiguresLib.TestTriangle
{
    internal class TestTriangleNegative
    {
        [Test]
        public void TestTriangleNegative1()
        {
            try
            {
                Triangle triangle = new Triangle(4, 7, -1);
            }
            catch (ArgumentException ex)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void TestTriangleNegative2()
        {
            try
            {
                Triangle triangle = new Triangle(-0.00001, -0.0002, -0.3);
            }
            catch (ArgumentException ex)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
