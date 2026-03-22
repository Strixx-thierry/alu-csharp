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
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
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
            
            result[i, 0] = Math.Round(x * cosA - y * sinA, 2);
            result[i, 1] = Math.Round(x * sinA + y * cosA, 2);
        }

        return result;
    }
}

