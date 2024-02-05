using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment2.Tests
{
    public class RectangleTests
    {
        private Rectangle _rectangle { get; set; } = null;

        [SetUp]
        public void SetUp()
        {

            _rectangle = new Rectangle();
        }


        [Test]
        public void TestRectangle()
        {
            // Assign
            var width = 122;
            var length = 140;

            // Act
            var perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.Equals(786, perimeter);
        }

    }
}