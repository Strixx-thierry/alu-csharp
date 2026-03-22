using System;

/// <summary>
/// A class for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The vector to calculate magnitude for.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sumSquares = 0;
        foreach (double x in vector)
        {
            sumSquares += x * x;
        }

        return Math.Round(Math.Sqrt(sumSquares), 2);
    }
}
