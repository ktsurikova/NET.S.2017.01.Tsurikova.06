using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /// <summary>
    /// determine possible kinds of sortings
    /// </summary>
    public enum Sorting
    {
        Sum, MaxElement, MinElement
    }

    /// <summary>
    /// provides method for sorting jagged arrays
    /// </summary>
    public class Sortings
    {
        /// <summary>
        /// method for sorting jagged arrays according to Sorting value
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="sorting">enum element according to which the array will be sorted</param>
        /// <param name="ascending">determine the order ascending/descending</param>
        /// <exception cref="ArgumentNullException">throws when array or its subarray is null</exception>
        public static void Sort(int[][] array, Sorting sorting, bool ascending = true)
        {
            if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null");
            Comparison<int[]> comparison = DefineComparer(sorting);
            int i = 0;
            bool fl = true;
            while (fl)
            {
                fl = false;
                for (int j = 0; j < array.GetLength(0) - i - 1; j++)
                {
                    if (!((comparison(array[j], array[j + 1]) > 0) ^ ascending))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        fl = true;
                    }
                }
                i++;
            }
        }

        private static Comparison<int[]> DefineComparer(Sorting sort)
        {
            switch (sort)
            {
                case Sorting.Sum:
                    return (x, y) => new SumComparer().Compare(x, y);
                case Sorting.MaxElement:
                    return (x, y) => new MaxElementComparer().Compare(x, y);
                case Sorting.MinElement:
                    return (x, y) => new MinElementComparer().Compare(x, y);
                default:
                    return (x, y) => new SumComparer().Compare(x, y);
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}
