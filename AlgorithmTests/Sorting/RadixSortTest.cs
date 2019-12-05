using Xunit;
using Algorithms.Sorting;

namespace AlgorithmTests.Sorting
{
    public class RadixSortTest
    {
        [Fact]
        public void Sort(){
            int[] arr = new int[] {170, 45, 75, 90, 802, 24, 2, 66};
            int[] resultArr = new int[] {2, 24, 45, 66, 75, 90, 170, 802};
            RadixSort radixSort = new RadixSort();
            radixSort.Sort(arr);
            Assert.Equal(resultArr, arr);
        }

        [Fact]
        public void SortWithEmptyArray(){
            int[] arr = new int[] {};
            int[] resultArr = new int[] {};
            RadixSort radixSort = new RadixSort();
            radixSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }
    }
}