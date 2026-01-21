using System;
using System.Collections.Generic;

class List
{
    /// <summary>
    /// Finds all multiples of 2 in a list.
    /// </summary>
    /// <param name="myList">The list of integers.</param>
    /// <returns>A list of booleans indicating divisibility by 2.</returns>
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        foreach (int num in myList)
        {
            result.Add(num % 2 == 0);
        }

        return result;
    }
}
