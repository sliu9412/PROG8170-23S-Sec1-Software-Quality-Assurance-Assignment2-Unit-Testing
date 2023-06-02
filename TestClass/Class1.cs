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
        // Equilateral Triangle Testings
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

        // Isosceles Triangle Testings
        [Test]
        public void IsoscelesTriangleTest_Input5and4and4_OutputIsosceles()
        {
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 4;

            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsoscelesTriangleTest_Input5and3and3_OutputIsosceles()
        {
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 3;

            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsoscelesTriangleTest_Input4and5and5_OutputIsosceles()
        {
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 5;

            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        // Scalene Triangle Testings
        [Test]
        public void ScaleneTriangleTest_Input5and4and3_OutputScalene()
        {
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 3;

            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and4and3_OutputScalene()
        {
            int firstSide = 6;
            int secondSide = 4;
            int thirdSide = 3;

            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and5and3_OutputScalene()
        {
            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 3;

            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and5and4_OutputScalene()
        {
            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 4;

            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input7and5and4_OutputScalene()
        {
            int firstSide = 7;
            int secondSide = 5;
            int thirdSide = 4;

            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, actual);
        }
    }
}
