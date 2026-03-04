using MyMath;
using System;

namespace MyMath.Tests
{
    /// <summary>
    /// This class contains unit tests for the Matrix class.
    /// </summary>
    public class MatrixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Divide_MatrixByNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.That(result, Is.EqualTo(new int[,] { { 1, 2 }, { 3, 4 } }));
        }

        [Test]
        public void Divide_MatrixByNegativeNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, -2);
            Assert.That(result, Is.EqualTo(new int[,] { { -1, -2 }, { -3, -4 } }));
        }

        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.That(result, Is.Null);
        }
    }
}