using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common = new List<int>();
        foreach (int item1 in list1)
        {
            if (list2.Contains(item1) && !common.Contains(item1))
            {
                common.Add(item1);
            }
        }
        common.Sort();
        return common;
    }
}
