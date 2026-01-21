using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Returns the number of keys in a dictionary.
    /// </summary>
    /// <param name="myDict">The dictionary.</param>
    /// <returns>The number of keys.</returns>
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        foreach (var key in myDict.Keys)
        {
            count++;
        }
        return count;
    }
}
