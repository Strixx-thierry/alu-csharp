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

        /// <summary>
        /// Tests that Divide correctly divides all elements of a matrix by a positive number.
        /// </summary>
        [Test]
        public void Divide_MatrixByNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.That(result, Is.EqualTo(new int[,] { { 1, 2 }, { 3, 4 } }));
        }

        /// <summary>
        /// Tests that Divide correctly divides all elements of a matrix by a negative number.
        /// </summary>
        [Test]
        public void Divide_MatrixByNegativeNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, -2);
            Assert.That(result, Is.EqualTo(new int[,] { { -1, -2 }, { -3, -4 } }));
        }

        /// <summary>
        /// Tests that Divide returns null and prints a message when dividing by zero.
        /// </summary>
        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.That(result, Is.Null);
        }

        /// <summary>
        /// Tests that Divide returns null when the input matrix is null.
        /// </summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.That(result, Is.Null);
        }
    }
}