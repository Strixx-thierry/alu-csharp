using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Deletes a key in a dictionary.
    /// </summary>
    /// <param name="myDict">The dictionary.</param>
    /// <param name="key">The key to delete.</param>
    /// <returns>The updated dictionary.</returns>
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        myDict.Remove(key);
        return myDict;
    }
}
