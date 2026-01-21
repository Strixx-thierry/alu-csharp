using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Returns a new dictionary with all values multiplied by 2.
    /// </summary>
    /// <param name="myDict">The original dictionary.</param>
    /// <returns>A new dictionary.</returns>
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> entry in myDict)
        {
            newDict.Add(entry.Key, entry.Value * 2);
        }
        return newDict;
    }
}
