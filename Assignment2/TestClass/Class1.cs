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
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            // Act
            string expected = "An EQUILATERAL triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Isosceles Triangle Testings
        [Test]
        public void IsoscelesTriangleTest_Input5and4and4_OutputIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 4;
            // Act
            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsoscelesTriangleTest_Input5and3and3_OutputIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 3;
            // Act
            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsoscelesTriangleTest_Input4and5and5_OutputIsosceles()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 5;
            // Act
            string expected = "An ISOSCELES triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Scalene Triangle Testings
        [Test]
        public void ScaleneTriangleTest_Input5and4and3_OutputScalene()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 3;
            // Act
            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and4and3_OutputScalene()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 4;
            int thirdSide = 3;
            // Act
            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and5and3_OutputScalene()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 3;
            // Act
            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input6and5and4_OutputScalene()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 4;
            // Act
            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ScaleneTriangleTest_Input7and5and4_OutputScalene()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 5;
            int thirdSide = 4;
            // Act
            string expected = "A SCALENE triangle is formed";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Zero Sides Triangle Testings
        [Test]
        public void ZeroSidesTriangleTest_Input5and4and0_OutputInvalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 0;
            // Act
            string expected = "Invalid Triangle - at least one side is zero";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ZeroSidesTriangleTest_Input5and0and0_OutputInvalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 0;
            int thirdSide = 0;
            // Act
            string expected = "Invalid Triangle - at least one side is zero";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ZeroSidesTriangleTest_Input0and0and0_OutputInvalid()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;
            // Act
            string expected = "Invalid Triangle - at least one side is zero";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Invaild Sides Triangle Testings
        [Test]
        public void InvalidSidesTriangleTest_Input6and3and3_OutputInvalid()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 3;
            int thirdSide = 3;
            // Act
            string expected = "INVALID Triangle detected!!";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidSidesTriangleTest_Input8and4and3_OutputInvalid()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 4;
            int thirdSide = 3;
            // Act
            string expected = "INVALID Triangle detected!!";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidSidesTriangleTest_Input5and5and10_OutputInvalid()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 10;
            // Act
            string expected = "INVALID Triangle detected!!";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
