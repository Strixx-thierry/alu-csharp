using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This class contains standard math operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// This method finds the maximum integer in a list.
        /// </summary>
        /// <param name="nums">The list of integers.</param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}
