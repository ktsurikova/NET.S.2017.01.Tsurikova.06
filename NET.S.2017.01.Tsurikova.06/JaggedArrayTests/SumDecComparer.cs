using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray;

namespace JaggedArrayTests
{
    public class SumDecComparer:IComparer
    {
        public int Compare(int[] lhs, int[] rhs) => rhs.Sum().CompareTo(lhs.Sum());
    }
}
