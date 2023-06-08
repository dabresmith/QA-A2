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

        
    }
}