using Assignment2;

namespace Assignment2.Tests
{
    public class Tests
    {
        private Rectangle _rectangle { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        // Unit tests for the GetLength function
        [Test]
        public void Test1()
        {
            // Assign
            // Nohing to Assign, using default constructor

            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(1, length);
        }
        [Test]
        public void Test2()
        {
            // Assign using the parem constructor
            _rectangle = new Rectangle(10, 15);

            // Act
            var length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(10, length);
        }
        [Test]
        public void Test3()
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
        public void Test4()
        {
            // Assign
            // Nohing to Assign, using default constructor

            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(1, width);
        }
        [Test]
        public void Test5()
        {
            // Assign using the parem constructor
            _rectangle = new Rectangle(10, 15);

            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(15, width);
        }
        [Test]
        public void Test6()
        {
            // Assign
            _rectangle.SetWidth(462);
            // Act
            var width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(462, width);
        }
    }
}