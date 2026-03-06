using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// This class contains string operations.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// This method checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            // Remove punctuation and spaces, and convert to lowercase
            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
