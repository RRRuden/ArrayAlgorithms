using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class ArrayExtensions
    {
        public static void Switch<T>(this T[] array, int i, int j)
        {
            var element = array[i];
            array[i] = array[j];
            array[j] = element;
        }
    }
}
