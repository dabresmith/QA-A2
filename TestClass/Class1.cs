using TriangleSolver;
using System;
using NUnit.Framework;

namespace TestClass
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void isEquilateralTriangle()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 8;
            side2 = 8;
            side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }

        [Test]
        public void isIsoscelesTriangle1()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 5;
            side2 = 5;
            side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void isIsoscelesTriangle2()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 7;
            side2 = 5;
            side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void isIsoscelesTriangle3()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 6;
            side2 = 9;
            side3 = 9;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
    }
}