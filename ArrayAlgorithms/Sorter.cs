namespace ArrayAlgorithms
{
    public static class Sorter
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            if (end == start) return;
            int index = start;
            int pivot = array[end];
            for (int i = start; i <= end - 1; i++)
            {
                if (array[i] <= pivot)
                {
                    array.Switch(i, index);
                    index++;
                }
            }
            array.Switch(end, index);
            if (index > start) QuickSort(array, start, index - 1);
            if (index < end) QuickSort(array, index + 1, end);
        }
        public static void Switch(this int[] array, int i, int j)
        {
            int element = array[i];
            array[i] = array[j];
            array[j] = element;
        }
    }
}