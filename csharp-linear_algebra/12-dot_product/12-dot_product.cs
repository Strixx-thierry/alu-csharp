using System;

/// <summary>
/// A class for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>Dot product, or -1 if invalid.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
        {
            return -1;
        }

        double result = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}
