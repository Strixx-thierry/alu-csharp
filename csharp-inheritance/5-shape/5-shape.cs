using System;

/// <summary>
/// This class represents a base Shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>None. Throws NotImplementedException.</returns>
    /// <exception cref="NotImplementedException">Thrown always with message Area() is not implemented.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
