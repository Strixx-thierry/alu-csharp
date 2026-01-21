using System;

class Array
{
    /// <summary>
    /// Replaces an element of an array at a given index.
    /// </summary>
    /// <param name="array">The original array.</param>
    /// <param name="index">The index to replace.</param>
    /// <param name="n">The new value.</param>
    /// <returns>The updated array, or the unchanged array if out of range.</returns>
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        array[index] = n;
        return array;
    }
}
