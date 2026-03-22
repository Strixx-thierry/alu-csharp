using System;

/// <summary>
/// A class for vector calculations.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar.
    /// </summary>
    /// <param name="vector">Vector to multiply.</param>
    /// <param name="scalar">Scalar value.</param>
    /// <returns>Resulting vector, or [-1] if invalid.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
