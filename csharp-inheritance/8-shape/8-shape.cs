using System;

/// <summary>
/// This class represents a base Shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>This method is not implemented in the base class.</returns>
    /// <exception cref="NotImplementedException">Thrown always with message Area() is not implemented.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// This class represents a Rectangle, inheriting from Shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when value is negative.</exception>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when value is negative.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the Rectangle.
    /// </summary>
    /// <returns>A string in the format [Rectangle] width / height.</returns>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <summary>
/// This class represents a Square, inheriting from Rectangle.
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when value is negative.</exception>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;
        }
    }
}
