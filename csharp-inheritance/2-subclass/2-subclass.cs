using System;

/// <summary>
/// This class contains methods for object type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if a type is a subclass of another type, excluding the base type itself.
    /// </summary>
    /// <param name="derivedType">The type to check.</param>
    /// <param name="baseType">The base type.</param>
    /// <returns>True if derivedType is a subclass of baseType, False otherwise.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
