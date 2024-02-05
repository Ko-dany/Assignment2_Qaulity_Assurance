/*
 * Program: PROG2070-SEC8
 * Purpose: Assignment 2
 * Revision History:
 *      created by Stefan Kobetich, Dahyun Ko, Feb/4/2024
 */

using Assignment2;

namespace Assignment2.Tests
{
    public class RectangleTests
    {
        private Rectangle _rectangle { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        // Unit tests for the GetLength function
        [Test]
        public void TestGetLength1()
        {
            // Assign
            // Nohing to Assign, using default constructor

            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(1, length);
        }
        [Test]
        public void TestGetLength2()
        {
            // Assign using the parem constructor
            _rectangle = new Rectangle(10, 15);

            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(10, length);
        }
        [Test]
        public void TestGetLength3()
        {
            // Assign
            _rectangle.SetLength(936);
            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(936, length);
        }

        // Unit tests for the GetWidth function
        [Test]
        public void TestGetWidth1()
        {
            // Assign
            // Nohing to Assign, using default constructor

            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(1, width);
        }
        [Test]
        public void TestGetWidth2()
        {
            // Assign using the parem constructor
            _rectangle = new Rectangle(10, 15);

            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(15, width);
        }
        [Test]
        public void TestGetWidth3()
        {
            // Assign
            _rectangle.SetWidth(462);
            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(462, width);
        }

        // Unit tests for the SetLength function
        [TestCase(50)]
        [TestCase(150)]
        [TestCase(500)]
        public void TestSetLength(int testLength)
        {
            // Assign
            var expectedResult = testLength;
            _rectangle.SetLength(testLength);

            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, length);
        }

        // Unit tests for the SetWidth function
        [TestCase(-50)]
        [TestCase(1101)]
        [TestCase(1300)]
        public void TestSetWidth(int testWidth)
        {
            // Assign
            var expectedResult = 1;
            _rectangle.SetWidth(testWidth);

            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, width);
        }
        // Unit tests for the GetPerimeter function
        [TestCase(4, 9)]
        [TestCase(37, 58)]
        [TestCase(129, 80)]
        public void TestGetPerimeter(int testLength, int testWidth)
        {
            // Assign
            var expectedResult = (testLength * 2) + (testWidth * 2);
            _rectangle = new Rectangle(testLength, testWidth);

            // Act
            var perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedResult, perimeter);
        }
        // Unit tests for the GetArea function
        [TestCase(5, 8)]
        [TestCase(63, 27)]
        [TestCase(243, 197)]
        public void TestGetArea(int testLength, int testWidth)
        {
            // Assign
            var expectedResult = testLength * testWidth;
            _rectangle = new Rectangle(testLength, testWidth);

            // Act
            var area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedResult, area);
        }
    }
}