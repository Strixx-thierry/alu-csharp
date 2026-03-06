using System;

/// <summary>
/// This class contains methods for object type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if an object is an instance of Array or inherits from Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is an instance of Array or a subclass of it, otherwise False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
