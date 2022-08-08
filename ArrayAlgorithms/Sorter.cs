namespace ArrayAlgorithms
{
    public static class Sorter
    {
        public static void QuickSort<T>(T[] array) where T : IComparable
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSort<T>(T[] array, int start, int end) where T : IComparable
        {
            if (end == start) return;
            int index = start;
            var pivot = array[end];
            for (int i = start; i <= end - 1; i++)
            {
                if (pivot.CompareTo(array[i]) > 0)
                {
                    array.Switch(i, index);
                    index++;
                }
            }
            array.Switch(end, index);
            if (index > start) QuickSort(array, start, index - 1);
            if (index < end) QuickSort(array, index + 1, end);
        }
    }
}