using System;

/// <summary>
/// A class for matrix calculations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a 2D matrix by a given factor in X or Y direction.
    /// </summary>
    /// <param name="matrix">2D matrix to shear.</param>
    /// <param name="direction">Direction 'x' or 'y'.</param>
    /// <param name="factor">Shear factor.</param>
    /// <returns>Resulting matrix, or [-1] if invalid.</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2 || (direction != 'x' && direction != 'y'))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            if (direction == 'x')
            {
                result[i, 0] = x + factor * y;
                result[i, 1] = y;
            }
            else // direction == 'y'
            {
                result[i, 0] = x;
                result[i, 1] = y + factor * x;
            }
        }

        return result;
    }
}
