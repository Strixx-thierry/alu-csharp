using System;
using System.Collections.Generic;

class List
{
    /// <summary>
    /// Finds the biggest integer of a list.
    /// </summary>
    /// <param name="myList">The list of integers.</param>
    /// <returns>The largest element, or -1 if empty.</returns>
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0];
        foreach (int num in myList)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
