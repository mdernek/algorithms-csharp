using Xunit;
using Algorithms.Sorting;

namespace AlgorithmTests.Sorting
{
    public class CountingSortTest
    {
        [Fact]
        public void Sort(){
            int[] arr = new int[] {80, 42, 99, 34, 54, 72, 78, 53, 1, 19, 28, 84, 3, 56, 64, 17, 86, 82, 17, 16, 2, 77, 83, 97, 30, 8, 35, 85, 40, 93, 54, 53, 3, 38, 19, 81, 74, 19, 6, 98, 5, 60, 72, 10, 32, 71, 40, 68, 1, 39, 11, 66, 68, 3, 88, 88, 87, 30, 34, 78, 74, 98, 47, 70, 13, 55, 82, 19, 43, 17, 96, 98, 63, 27, 95, 9, 13, 20, 47, 16, 95, 55, 29, 86, 44, 42, 67, 62, 100, 2, 17, 32, 99, 30, 75, 92, 43, 77, 39, 3};
            int[] resultArr = new int[] {1, 1, 2, 2, 3, 3, 3, 3, 5, 6, 8, 9, 10, 11, 13, 13, 16, 16, 17, 17, 17, 17, 19, 19, 19, 19, 20, 27, 28, 29, 30, 30, 30, 32, 32, 34, 34, 35, 38, 39, 39, 40, 40, 42, 42, 43, 43, 44, 47, 47, 53, 53, 54, 54, 55, 55, 56, 60, 62, 63, 64, 66, 67, 68, 68, 70, 71, 72, 72, 74, 74, 75, 77, 77, 78, 78, 80, 81, 82, 82, 83, 84, 85, 86, 86, 87, 88, 88, 92, 93, 95, 95, 96, 97, 98, 98, 98, 99, 99, 100};
            CountingSort countingSort = new CountingSort();
            countingSort.Sort(arr);
            Assert.Equal(resultArr, arr);
        }

        [Fact]
        public void SortWithEmptyArray(){
            int[] arr = new int[] {};
            int[] resultArr = new int[] {};
            CountingSort countingSort = new CountingSort();
            countingSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }
    }
}