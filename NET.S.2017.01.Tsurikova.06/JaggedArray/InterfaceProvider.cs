using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class InterfaceProvider : IComparer
    {
        private Comparison<int[]> comparer;

        public InterfaceProvider(Comparison<int[]> otherComparer)
        {
            if (ReferenceEquals(otherComparer, null))
                throw new ArgumentNullException($"{nameof(otherComparer)} is null");
            comparer = otherComparer;
        }

        public int Compare(int[] lhs, int[] rhs) => comparer(lhs, rhs);
    }
}
