using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Geometry;

namespace GeometryTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareRightTest()
        {
            double r = 5;
            double expected = Math.PI * r * r;
            double result = Circle.Square(r);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SquareZeroTest()
        {
            double r = 0;
            double expected = 0;
            double result = Circle.Square(r);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SquareNegativeTest()
        {
            double r = -5;
            double result = Circle.Square(r);
        }
    }
}
