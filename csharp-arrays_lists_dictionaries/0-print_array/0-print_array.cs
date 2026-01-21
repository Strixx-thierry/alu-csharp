using System;

class Array
{
    /// <summary>
    /// Creates and prints an array of integers of a given size.
    /// </summary>
    /// <param name="size">The size of the array.</param>
    /// <returns>The new array, or null if size is negative.</returns>
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write(newArray[i]);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
        return newArray;
    }
}
