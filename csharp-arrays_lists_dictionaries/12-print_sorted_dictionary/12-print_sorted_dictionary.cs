using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Prints a dictionary by ordered keys.
    /// </summary>
    /// <param name="myDict">The dictionary to print.</param>
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
