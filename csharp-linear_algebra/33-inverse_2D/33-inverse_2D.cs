using System;

/// <summary>
/// A class for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix">2D matrix to invert.</param>
    /// <returns>Resulting matrix, or [-1] if invalid.</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];
        result[0, 0] = Math.Round(matrix[1, 1] / det, 2);
        result[0, 1] = Math.Round(-matrix[0, 1] / det, 2);
        result[1, 0] = Math.Round(-matrix[1, 0] / det, 2);
        result[1, 1] = Math.Round(matrix[0, 0] / det, 2);

        return result;
    }
}
