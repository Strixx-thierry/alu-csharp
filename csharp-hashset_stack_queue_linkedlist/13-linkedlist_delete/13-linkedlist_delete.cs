using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0)
        {
            return;
        }

        LinkedListNode<int> current = myLList.First;
        int i = 0;

        while (current != null)
        {
            if (i == index)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            i++;
        }
    }
}
