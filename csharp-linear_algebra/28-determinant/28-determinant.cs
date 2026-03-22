using System;

/// <summary>
/// A class for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix.
    /// </summary>
    /// <param name="matrix">Matrix to calculate determinant for.</param>
    /// <returns>Determinant, or -1 if invalid.</returns>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols || (rows != 2 && rows != 3))
        {
            return -1;
        }

        if (rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else // rows == 3
        {
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 0];
            double e = matrix[1, 1];
            double f = matrix[1, 2];
            double g = matrix[2, 0];
            double h = matrix[2, 1];
            double i = matrix[2, 2];

            return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
        }
    }
}
