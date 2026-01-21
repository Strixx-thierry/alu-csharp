using System;
using System.Collections.Generic;

class List
{
    /// <summary>
    /// Deletes the item at a specific position in a list.
    /// </summary>
    /// <param name="myList">The list to modify.</param>
    /// <param name="index">The index to remove.</param>
    /// <returns>The updated list.</returns>
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        myList.Remove(myList[index]);
        return myList;
    }
}
