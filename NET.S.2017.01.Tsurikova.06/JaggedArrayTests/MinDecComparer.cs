using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray;

namespace JaggedArrayTests
{
    public class MinDecComparer:IComparer
    {
        public int Compare(int[] lhs, int[] rhs) => rhs.Min().CompareTo(lhs.Min());
    }
}
