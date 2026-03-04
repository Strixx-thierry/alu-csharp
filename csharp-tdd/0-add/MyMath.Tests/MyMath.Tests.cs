using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// This class contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            int result = Operations.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            int result = Operations.Add(-1, -2);
            Assert.That(result, Is.EqualTo(-3));
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int result = Operations.Add(5, -2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_Zero_ReturnsOtherNumber()
        {
            int result = Operations.Add(0, 5);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}