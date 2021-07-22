using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    class LinearSearch : Program
    {
        protected internal static string FindExistence(int[] ListsData, int targetValue)
        {
            for(int x = 0; x < ListsData.Length; x++)
            {
                if (targetValue == ListsData[x])
                    return "Element is present at index: " + x;
            }

            return "Element isn't present in lists.";
        }
    }
}
