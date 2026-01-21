using System;

class Array
{
    /// <summary>
    /// Prints all integers of an array, in reverse order.
    /// </summary>
    /// <param name="array">The array to print.</param>
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
