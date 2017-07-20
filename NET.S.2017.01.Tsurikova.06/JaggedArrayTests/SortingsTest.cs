using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray;
using NUnit.Framework;

namespace JaggedArrayTests
{
    class SortingsTest
    {
        #region Sum

        public static IEnumerable<TestCaseData> TestDataForSum
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                    new[] {6,6,6, 6},
                    new[] {2,2,2, 2},
                    new[] {3, 3, 3, 3},
                    new[] {5, 5, 5, 5},
                    new[] {4, 4, 4, 4},
                }, new[]{
                    new[] {2,2,2, 2},
                    new[] {3, 3, 3, 3},
                    new[] {4, 4, 4, 4},
                    new[] {5, 5, 5, 5},
                    new[] {6, 6, 6, 6},
                });
            }
        }

        [Test, TestCaseSource(nameof(TestDataForSum))]
        public void Sort_Array_Sum_Asc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, (i1, i2)=>i1.Sum()-i2.Sum());
            IStructuralEquatable sq = array;
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        [Test, TestCaseSource(nameof(TestDataForSum))]
        public void Sort_Array_Sum_Desc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, new SumDecComparer());
            IStructuralEquatable sq = array;
            Array.Reverse(sorted);
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        #endregion

        #region Min

        public static IEnumerable<TestCaseData> TestDataForMin
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                    new[] {6,5,6},
                    new[] {4,3,5},
                    new[] {3, 2, 3},
                    new[] {4, 4, 4, 4},
                    new[] {5, 1, 5, 5, 5}
                }, new[]{
                    new[] {5, 1, 5, 5, 5},
                    new[] {3, 2, 3},
                    new[] {4,3,5},
                    new[] {4, 4, 4, 4},
                    new[] {6,5,6}
                });
            }
        }

        [Test, TestCaseSource(nameof(TestDataForMin))]
        public void Sort_Array_Min_Asc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, new MinInComparer());
            IStructuralEquatable sq = array;
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        [Test, TestCaseSource(nameof(TestDataForMin))]
        public void Sort_Array_Min_Desc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, new MinDecComparer());
            IStructuralEquatable sq = array;
            Array.Reverse(sorted);
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        #endregion

        #region Max

        public static IEnumerable<TestCaseData> TestDataForMax
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                    new[] {6, 1, 5, 5, 5},
                    new[] {4,3,5},
                    new[] {1,1},
                    new[] {4, 4, 4, 4},
                    new[] {3, 2, 3}
                }, new[]{
                    new[] {1,1},
                    new[] {3, 2, 3},
                    new[] {4, 4, 4, 4},
                    new[] {4,3,5},
                    new[] {6, 1, 5, 5, 5}
                });
            }
        }

        [Test, TestCaseSource(nameof(TestDataForMax))]
        public void Sort_Array_Max_Asc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, new MaxInComparer()); ;
            IStructuralEquatable sq = array;
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        [Test, TestCaseSource(nameof(TestDataForMax))]
        public void Sort_Array_Max_Desc_SortedArray(int[][] array, int[][] sorted)
        {
            Sortings.Sort(array, new MaxDecComparer());
            IStructuralEquatable sq = array;
            Array.Reverse(sorted);
            Assert.True(sq.Equals(sorted, StructuralComparisons.StructuralEqualityComparer));
        }

        #endregion

    }
}
