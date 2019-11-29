using Xunit;
using Algorithms.Searching;

namespace AlgorithmTests.Searching
{
    public class BinarySearchTest
    {
        [Fact]
        public void BinarySearchKeyFound(){
            int[] arr = new int[] {1,2,3,4,5,6,7,8};
            BinarySearch binarySearch = new BinarySearch();
            int index = binarySearch.Search(arr, 6);

            Assert.Equal(5, index);
        }

        [Fact]
        public void BinarySearchKeyNotFound(){
            int[] arr = new int[] {1,2,3,4,5,6,7,8};
            BinarySearch binarySearch = new BinarySearch();
            int index = binarySearch.Search(arr, 9);

            Assert.Equal(-1, index);
        }

        [Fact]
        public void BinarySearchWithEmptyArray(){
            int[] arr = new int[] {};
            BinarySearch binarySearch = new BinarySearch();
            int index = binarySearch.Search(arr, 9);

            Assert.Equal(-1, index);
        }
    }
}