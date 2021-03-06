﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /// <summary>
    /// provides method for sorting jagged arrays
    /// </summary>
    public class Sortings
    {
        #region firstversion

        ///// <summary>
        ///// method for sorting jagged arrays
        ///// </summary>
        ///// <param name="array">array to be sorted</param>
        ///// <param name="comparer">specifies sorting feature</param>
        ///// <exception cref="ArgumentNullException">throws when array or its subarray is null</exception>
        //public static void Sort(int[][] array, IComparer comparer)
        //{
        //    CheckValidArray(array);
        //    if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null");
        //    Sort(array, comparer.Compare);
        //}

        ///// <summary>
        ///// method for sorting jagged arrays
        ///// </summary>
        ///// <param name="array">array to be sorted</param>
        ///// <param name="comparer">specifies sorting feature</param>
        ///// <exception cref="ArgumentNullException">throws when array or its subarray is null</exception>
        //public static void Sort(int[][] array, Comparison<int[]> comparer)
        //{
        //    CheckValidArray(array);
        //    if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null");

        //    int i = 0;
        //    bool fl = true;
        //    while (fl)
        //    {
        //        fl = false;
        //        for (int j = 0; j < array.GetLength(0) - i - 1; j++)
        //        {
        //            if (comparer(array[j], array[j + 1]) > 0)
        //            {
        //                Swap(ref array[j], ref array[j + 1]);
        //                fl = true;
        //            }
        //        }
        //        i++;
        //    }
        //} 

        #endregion

        #region secondversion

        /// <summary>
        /// method for sorting jagged arrays
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="comparer">specifies sorting feature</param>
        /// <exception cref="ArgumentNullException">throws when array or its subarray is null</exception>
        public static void Sort(int[][] array, IComparer comparer)
        {
            CheckValidArray(array);
            if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null");

            int i = 0;
            bool fl = true;
            while (fl)
            {
                fl = false;
                for (int j = 0; j < array.GetLength(0) - i - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        fl = true;
                    }
                }
                i++;
            }
        }

        /// <summary>
        /// method for sorting jagged arrays
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="comparer">specifies sorting feature</param>
        /// <exception cref="ArgumentNullException">throws when array or its subarray is null</exception>
        public static void Sort(int[][] array, Comparison<int[]> comparer)
        {
            CheckValidArray(array);
            if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null");
            Sort(array, new InterfaceProvider(comparer));
        }

        #endregion


        private static void CheckValidArray(int[][] array)
        {
            if (ReferenceEquals(array, null)) throw new ArgumentNullException($"{nameof(array)} is null");
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}
