using FiguresLib.Implementation.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFiguresLib.TestCircle
{
    internal class TestCircleNegative
    {
        [Test]
        public void TestCircleNegative1()
        {
            try
            {
                double negativeRadius = -10;
                Circle circle = new Circle(negativeRadius);
            }
            catch(ArgumentException ex)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void TestCircleNegative2()
        {
            try
            {
                double negativeRadius = -0.000001;
                Circle circle = new Circle(negativeRadius);
            }
            catch (ArgumentException ex)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
