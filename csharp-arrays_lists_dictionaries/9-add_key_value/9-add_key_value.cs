using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Adds a key and value to a dictionary.
    /// </summary>
    /// <param name="myDict">The dictionary.</param>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The updated dictionary.</returns>
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        myDict[key] = value;
        return myDict;
    }
}
