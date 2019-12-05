using Xunit;
using Algorithms.Sorting;

namespace AlgorithmTests.Sorting
{
    public class HeapSortTest
    {
        [Fact]
        public void Sort(){
            int[] arr = new int[] {7,6,10,5,9,2,1,15,7};
            int[] resultArr = new int[] {1,2,5,6,7,7,9,10,15};
            HeapSort heapSort = new HeapSort();
            heapSort.Sort(arr);
            Assert.Equal(resultArr, arr);
        }

        [Fact]
        public void SortWithEmptyArray(){
            int[] arr = new int[] {};
            int[] resultArr = new int[] {};
            HeapSort heapSort = new HeapSort();
            heapSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }
    }
}