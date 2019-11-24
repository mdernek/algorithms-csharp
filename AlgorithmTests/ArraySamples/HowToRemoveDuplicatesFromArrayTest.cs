using System.Collections.Generic;
using Xunit;
using Algorithms.ArraySamples;

namespace AlgorithmTests.ArraySamples
{
    public class HowToRemoveDuplicatesFromArrayTest: IClassFixture<HowToRemoveDuplicatesFromArray>
    {
        HowToRemoveDuplicatesFromArray _howToRemoveDuplicatesFromArray;
        public HowToRemoveDuplicatesFromArrayTest(HowToRemoveDuplicatesFromArray howToRemoveDuplicatesFromArray)
        {
            _howToRemoveDuplicatesFromArray = howToRemoveDuplicatesFromArray;
        }

        [Fact]
        public void RemoveDuplicatesFromArray(){
            int[] arr = new int[] {1, 2, 3, 1, 2, 5, 6, 7, 8};
            int[] expectedArray = new int[] {1, 2, 3, 5, 6, 7, 8};
            IEnumerable<int> actualArray = _howToRemoveDuplicatesFromArray.RemoveDuplicatesFromArray(arr);

            int i = 0;
            foreach(int item in actualArray){
                Assert.Equal(expectedArray[i], item);
                i++;
            }
        }
        
        [Fact]
        public void RemoveDuplicatesFromEmptyArray(){
            int[] arr = new int[] {};
            int[] expectedArray = new int[] {};
            IEnumerable<int> actualArray = _howToRemoveDuplicatesFromArray.RemoveDuplicatesFromArray(arr);
            Assert.Equal(expectedArray, actualArray);
        }
    }
}