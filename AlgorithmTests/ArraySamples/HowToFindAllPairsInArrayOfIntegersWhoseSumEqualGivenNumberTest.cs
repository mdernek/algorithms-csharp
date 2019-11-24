using System.Collections;
using System.Collections.Generic;
using Algorithms.ArraySamples;
using Xunit;

namespace AlgorithmTests.ArraySamples
{
    public class HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumberTest: IClassFixture<HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumber>
    {
        HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumber _howToFindAllPairs;

        public HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumberTest(HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumber howToFindAllPairs)
        {
            this._howToFindAllPairs = howToFindAllPairs;
        }

        [Fact]
        public void SumUsingSet(){
            int[] arr = new int[] {0, 14, 0, 4, 7, 8, 3, 5, 7};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(7, 4), (3, 8), (7, 4)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.SumUsingSet(arr, 11);

            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                (int pair1, int pair2) expected = expectedList[i];
                Assert.Equal(expected, actual);
                i++;
            }
        }

        [Fact]
        public void SumUsingSetWithZeroArray(){
            int[] arr = new int[] {};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(-1, -1)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.SumUsingSet(arr, 11);

            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                (int pair1, int pair2) expected = expectedList[i];
                Assert.Equal(expected, actual);
                i++;
            }
        }

        [Fact]
        public void SumUsingSetWithOneItemInArray(){
            int[] arr = new int[] {0};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(-1, -1)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.SumUsingSet(arr, 11);

            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                (int pair1, int pair2) expected = expectedList[i];
                Assert.Equal(expected, actual);
                i++;
            }
        }

        [Fact]
        public void SumUsingSetWithWrongArray(){
            int[] arr = new int[] {0,0};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(-1, -1)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.SumUsingSet(arr, 11);
            
            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                i++;
            }

            Assert.Equal(0, i);
        }

        [Fact]
        public void FindPairsUsingTwoPointers(){
            int[] arr = new int[] {12, 14, 17, 15, 19, 20, -11};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(20, -11)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.FindPairsUsingTwoPointers(arr, 9);

            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                (int pair1, int pair2) expected = expectedList[i];
                Assert.Equal(expected, actual);
                i++;
            }
        }

        [Fact]
        public void FindPairsUsingTwoPointersWithOneItemInArray(){
            int[] arr = new int[] {0};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(-1, -1)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.FindPairsUsingTwoPointers(arr, 11);

            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                (int pair1, int pair2) expected = expectedList[i];
                Assert.Equal(expected, actual);
                i++;
            }
        }

        [Fact]
        public void FindPairsUsingTwoPointersWithWrongArray(){
            int[] arr = new int[] {0,0};
            (int pair1, int pair2)[] expectedList = new (int pair1, int pair2)[] {(-1, -1)};
            IEnumerable<(int pair1, int pair2)> actualList = _howToFindAllPairs.FindPairsUsingTwoPointers(arr, 11);
            
            int i = 0;
            foreach ((int pair1, int pair2) actual in actualList)
            {
                i++;
            }

            Assert.Equal(0, i);
        }
    }
}