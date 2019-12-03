using Xunit;
using Algorithms.Sorting;

namespace AlgorithmTests.Sorting
{
    public class QuickSortTest
    {
        [Fact]
        public void Sort(){
            int[] arr = new int[] {7,6,10,5,9,2,1,15,7};
            int[] resultArr = new int[] {1,2,5,6,7,7,9,10,15};
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }

        [Fact]
        public void SortWithEmptyArray(){
            int[] arr = new int[] {};
            int[] resultArr = new int[] {};
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }
    }
}