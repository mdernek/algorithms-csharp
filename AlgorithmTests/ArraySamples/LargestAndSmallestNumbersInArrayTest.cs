using Algorithms.ArraySamples;
using Xunit;

namespace AlgorithmTests.ArraySamples
{
    public class LargestAndSmallestNumbersInArrayTest: IClassFixture<LargestAndSmallestNumbersInArray>
    {
        LargestAndSmallestNumbersInArray _largestAndSmallestNumbersInArray;

        public LargestAndSmallestNumbersInArrayTest(LargestAndSmallestNumbersInArray largestAndSmallestNumbersInArray)
        {
            _largestAndSmallestNumbersInArray = largestAndSmallestNumbersInArray;
        }

        [Fact]
        public void FindLargestAndSmallestNumbersInArray() {
            int[] arr = new int[] {-20, 34, 21, -87, 92, 2147483647};
            (int largest, int smallest) actual = _largestAndSmallestNumbersInArray.FindLargestAndSmallestNumbersInArray(arr);
            Assert.Equal((2147483647, -87), actual);

            arr = new int[] {2147483647, 40, 2147483647};
            actual = _largestAndSmallestNumbersInArray.FindLargestAndSmallestNumbersInArray(arr);
            Assert.Equal((2147483647, 40), actual);

            arr = new int[] {10, -2147483648, -2};
            actual = _largestAndSmallestNumbersInArray.FindLargestAndSmallestNumbersInArray(arr);
            Assert.Equal((10, -2147483648), actual);
        }
    }
}