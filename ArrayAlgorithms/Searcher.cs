using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class Searcher
    {
        public static int BinarySearch(int[] array, int element)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (array[mid] < element) left = mid + 1;
                else right = mid;
            }
            if (array[right] == element) return right;
            return -1;
        }
    }
}
