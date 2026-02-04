using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diff = new List<int>();

        foreach (int item1 in list1)
        {
            if (!list2.Contains(item1) && !diff.Contains(item1))
            {
                diff.Add(item1);
            }
        }

        foreach (int item2 in list2)
        {
            if (!list1.Contains(item2) && !diff.Contains(item2))
            {
                diff.Add(item2);
            }
        }

        diff.Sort();
        return diff;
    }
}
