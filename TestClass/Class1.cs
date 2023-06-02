using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void EquilateralTriangleTest_Input5and5and5_OutputEquilateral()
        {
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;

            string expected = "An EQUILATERAL triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
