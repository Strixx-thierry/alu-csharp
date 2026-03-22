using System;

/// <summary>
/// A class for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a 2D matrix by a given angle.
    /// </summary>
    /// <param name="matrix">2D matrix to rotate.</param>
    /// <param name="angle">Angle in radians.</param>
    /// <returns>Resulting matrix, or [-1] if invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double cosA = Math.Cos(angle);
        double sinA = Math.Sin(angle);

        double[,] result = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];
            
            result[i, 0] = x * cosA - y * sinA;
            result[i, 1] = x * sinA + y * cosA;
        }

        return result;
    }
}
