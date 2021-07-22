namespace SearchAlgorithms
{
    class BinarySearch
    {
        internal protected static string FindExistence(int[] inputLists, int targetValue)
        {
            int[] sortedList = SortLists(inputLists);

            int l = 0;
            int r = inputLists.Length;
            int feedbackNotation = BinarySearchOperation(sortedList, targetValue, l, r);

            if (feedbackNotation == -1)
                return "Element isn't present in lists.";

            return "Element is present at index: " + feedbackNotation;
        }

        private static int[] SortLists(int[] list)
        {
            int temp;

            for (int i = 0; i < list.Length; i++)
            {
                for(int j = 0; j < list.Length; j++)
                {
                    if (j != (list.Length - 1))
                    {
                        if (list[j] > list[j + 1])
                        {
                            temp = list[j + 1];
                            list[j + 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }

            return list;
        }

        private static int BinarySearchOperation(int[] dataLists, int searchData,
                                                                int startLength, int endLength)
        {
            if(endLength >= startLength)
            {
                int mid = startLength + (endLength - startLength) / 2;

                if (searchData == dataLists[mid])
                    return mid;

                if (searchData < dataLists[mid])
                    return BinarySearchOperation(dataLists, searchData, startLength, mid - 1);

                if (searchData > dataLists[mid])
                    return BinarySearchOperation(dataLists, searchData, mid + 1, endLength);
            }

            return -1;
        }
    }
}
