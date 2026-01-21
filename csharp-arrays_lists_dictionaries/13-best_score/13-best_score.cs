using System;
using System.Collections.Generic;

class Dictionary
{
    /// <summary>
    /// Returns the key with the biggest integer value in a given dictionary.
    /// </summary>
    /// <param name="myList">The dictionary.</param>
    /// <returns>The key with the biggest value, or "None".</returns>
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestKey = "";
        int maxVal = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxVal)
            {
                maxVal = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}
