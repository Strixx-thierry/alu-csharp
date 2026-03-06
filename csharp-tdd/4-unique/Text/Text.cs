using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// This class contains string operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// This method finds the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The index of the first non-repeating character, or -1 if none exist.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            int[] charCounts = new int[256];

            foreach (char c in s)
            {
                charCounts[c]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCounts[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
