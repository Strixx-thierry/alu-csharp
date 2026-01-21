using System;

class Array
{
    /// <summary>
    /// Retrieves an element from an array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <param name="index">The index to retrieve.</param>
    /// <returns>The element at the given index, or -1 if out of range.</returns>
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        return array[index];
    }
}
