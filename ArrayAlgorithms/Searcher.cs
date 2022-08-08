namespace ArrayAlgorithms
{
    public static class Searcher
    {
        public static int BinarySearch<T>(T [] array, int element) where T : IComparable
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (array[mid].CompareTo(element) < 0) left = mid + 1;
                else right = mid;
            }
            if (array[right].CompareTo(element)==0) return right;
            return -1;
        }
    }
}
