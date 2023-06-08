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


        [Test]

        public void isScaleneTriangle1()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 3;
            side2 = 4;
            side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]

        public void isScaleneTriangle2()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 6;
            side2 = 7;
            side3 = 9;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]

        public void isScaleneTriangle3()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 6;
            side2 = 7;
            side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]

        public void isScaleneTriangle4()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 5;
            side2 = 4;
            side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]

        public void isScaleneTriangle5()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 9;
            side2 = 8;
            side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void ZeroLengthSide1()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 0;
            side2 = 8;
            side3 = 2;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void ZeroLengthSide2()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 0;
            side2 = 6;
            side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void ZeroLengthSide3()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 0;
            side2 = 0;
            side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void ResponseInvalid1()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 1;
            side2 = 1;
            side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void ResponseInvalid2()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 20;
            side2 = 10;
            side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void ResponseInvalid3()
        {
            // Arrange 
            int side1, side2, side3;
            side1 = 6;
            side2 = 2;
            side3 = 2;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }
    }
}