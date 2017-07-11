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
    public class MaxElementComparerTests
    {
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 2, 2, 4 }, ExpectedResult = -1)]
        [TestCase(new[] { 5, 4, 3 }, new[] { 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { 1, 1, 1, 4, 1 }, new[] { 4, 2, 1 }, ExpectedResult = 0)]
        public int Compare_2Arrays_Result(int[] x, int[] y)
        {
            return new MaxElementComparer().Compare(x, y);
        }

        [Test]
        public void Comparer_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MaxElementComparer().Compare(null, new[] { 1 }));
        }
    }
}
