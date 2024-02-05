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
            _rectangle.SetLength(testLength);
            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(testLength, length);
        }

        // Unit tests for the SetWidth function

        [TestCase(-50)]
        [TestCase(1101)]
        [TestCase(1300)]
        public void TestSetWidth(int testWidth)
        {
            // Assign
            _rectangle.SetWidth(testWidth);
            // Act
            var expectedResult = 1;
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, width);
        }
        // Unit tests for the GetPerimeter function
        // Unit tests for the GetArea function

    }
}