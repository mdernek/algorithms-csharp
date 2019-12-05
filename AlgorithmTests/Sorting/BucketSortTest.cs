using Xunit;
using Algorithms.Sorting;

namespace AlgorithmTests.Sorting
{
    public class BucketSortTest
    {
        [Fact]
        public void Sort(){
            float[] arr = new float[] {0.897F, 0.565F, 0.656F, 0.1234F, 0.665F, 0.3434F};
            float[] resultArr = new float[] {0.1234F, 0.3434F, 0.565F, 0.656F, 0.665F, 0.897F};
            BucketSort bucketSort = new BucketSort();
            bucketSort.Sort(arr);
            Assert.Equal(resultArr, arr);
        }

        [Fact]
        public void SortWithEmptyArray(){
            float[] arr = new float[] {};
            float[] resultArr = new float[] {};
            BucketSort bucketSort = new BucketSort();
            bucketSort.Sort(arr);

            Assert.Equal(resultArr, arr);
        }
    }
}