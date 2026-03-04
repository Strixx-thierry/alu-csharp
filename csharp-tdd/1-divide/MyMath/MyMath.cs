using System;

namespace MyMath
{
    /// <summary>
    /// This class contains matrix operations.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// This method divides all elements of a matrix by a number.
        /// </summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The number to divide by.</param>
        /// <returns>A new matrix containing the divided elements, or null if the input matrix is null or num is 0.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            try
            {
                if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] newMatrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newMatrix[i, j] = matrix[i, j] / num;
                    }
                }

                return newMatrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
