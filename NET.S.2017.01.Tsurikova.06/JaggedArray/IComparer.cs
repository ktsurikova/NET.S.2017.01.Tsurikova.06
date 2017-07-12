using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /// <summary>
    /// interface for comparing arrays
    /// </summary>
    public interface IComparer
    {
        int Compare(int[] lhs, int[] rhs);
    }
}
