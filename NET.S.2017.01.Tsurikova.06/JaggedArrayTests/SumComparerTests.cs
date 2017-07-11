using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray;
using NUnit.Framework;

namespace JaggedArrayTests
{
    [TestFixture]
    public class SumComparerTests
    {
        [TestCase(new[] {1, 1, 1, 1, 1}, new[] {2, 2, 2}, ExpectedResult = -1)]
        [TestCase(new[] {1, 1, 1, 1, 1}, new[] {2, 2}, ExpectedResult = 1)]
        [TestCase(new[] {1, 1, 1, 1, 1}, new[] {5}, ExpectedResult = 0)]
        public int Compare_2Arrays_Result(int[] x, int[] y)
        {
            return new SumComparer().Compare(x, y);
        }

        [Test]
        public void Comparer_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SumComparer().Compare(null, new[] {1}));
        }
    }
}
