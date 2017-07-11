﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class MaxElementComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (ReferenceEquals(x, null)) throw new ArgumentNullException($"{nameof(x)} is null");
            if (ReferenceEquals(y, null)) throw new ArgumentNullException($"{nameof(x)} is null");

            return x.Max().CompareTo(y.Max());
        }
    }
}
