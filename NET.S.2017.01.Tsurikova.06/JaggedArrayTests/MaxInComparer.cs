using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray;

namespace JaggedArrayTests
{
    public class MaxInComparer : IComparer
    {
        public int Compare(int[] lhs, int[] rhs) => lhs.Max().CompareTo(rhs.Max());
    }
}
