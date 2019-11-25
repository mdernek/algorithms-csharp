using Algorithms.ArraySamples;
using Xunit;

namespace AlgorithmTests.ArraySamples
{
    public class MissingNumberInArrayTest: IClassFixture<MissingNumberInArray>
    {
        MissingNumberInArray _missingNumberInArray;

        public MissingNumberInArrayTest(MissingNumberInArray missingNumberInArray)
        {
            _missingNumberInArray = missingNumberInArray;
        }

        [Fact]
        public void FindOneMissingNumber(){
            int[] arr = new int[] {1,3,2,6,4};
            int actual = _missingNumberInArray.FindOneMissingNumber(arr);
            Assert.Equal(5, actual);

            arr = new int[] {1};
            actual = _missingNumberInArray.FindOneMissingNumber(arr);
            Assert.Equal(-1, actual);

            arr = new int[0];
            actual = _missingNumberInArray.FindOneMissingNumber(arr);
            Assert.Equal(-1, actual);
        }
        
        [Fact]
        public void FindOneMissingNumberInLargeArray(){
            int[] arr = new int[]{2,1,3,7,6,4,20,9,13,17,12,10,14,19,16,11,18,15,8}; 
            int actual = _missingNumberInArray.FindOneMissingNumberInLargeArray(arr);
            Assert.Equal(5, actual);

            arr = new int[] {1};
            actual = _missingNumberInArray.FindOneMissingNumberInLargeArray(arr);
            Assert.Equal(-1, actual);

            arr = new int[0];
            actual = _missingNumberInArray.FindOneMissingNumberInLargeArray(arr);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void FindOneMissingNumberWithXOR(){
            int[] arr = new int[]{2,1,3,7,6,4,20,9,13,17,12,10,14,19,16,11,18,15,8};
            int actual = _missingNumberInArray.FindOneMissingNumberWithXOR(arr);
            Assert.Equal(5, actual);

            arr = new int[] {1};
            actual = _missingNumberInArray.FindOneMissingNumberWithXOR(arr);
            Assert.Equal(-1, actual);

            arr = new int[0];
            actual = _missingNumberInArray.FindOneMissingNumberWithXOR(arr);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void FindOneMissingNumberInOrderedArray(){
            int[] arr = new int[]{1,2,3,4,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            int actual = _missingNumberInArray.FindOneMissingNumberInOrderedArray(arr);
            Assert.Equal(5, actual);

            arr = new int[] {1};
            actual = _missingNumberInArray.FindOneMissingNumberInOrderedArray(arr);
            Assert.Equal(-1, actual);

            arr = new int[0];
            actual = _missingNumberInArray.FindOneMissingNumberInOrderedArray(arr);
            Assert.Equal(-1, actual);
        }
    }
}