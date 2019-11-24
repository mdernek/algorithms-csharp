//How to Find all Pairs in Array of Integers Whose sum is Equal to a Given Number
//https://javarevisited.blogspot.com/2014/08/how-to-find-all-pairs-in-array-of-integers-whose-sum-equal-given-number-java.html?source=post_page---------------------------
using System;
using System.Collections.Generic;

namespace Algorithms.ArraySamples
{
    public class HowToFindAllPairsInArrayOfIntegersWhoseSumEqualGivenNumber
    {
        public IEnumerable<(int pair1, int pair2)> SumUsingSet(int[] arr, int givenNumber){
            int n = arr.Length;

            if(n < 2){
                yield return (-1, -1);
            }

            HashSet<int> potantialPairSet = new HashSet<int>();

            for(int i=0;i<n;i++){
                int potantialPair = givenNumber - arr[i];

                if(!potantialPairSet.Contains(potantialPair)) {
                    potantialPairSet.Add(arr[i]);
                }
                else {
                    yield return (arr[i], potantialPair);
                }
            }
        }

        public IEnumerable<(int pair1, int pair2)> FindPairsUsingTwoPointers(int[] arr, int givenNumber){
            int n = arr.Length;

            if(n < 2){
                yield return (-1, -1);
            }

            int l = 0;
            int r = n-1;

            while(l<=r){
                int sum = arr[l] + arr[r];

                if(sum == givenNumber) {
                    (int pair1, int pair2) pair = (arr[l], arr[r]);
                    l++;
                    r--;
                    yield return pair;

                }
                else if(sum < givenNumber){
                    l++;
                }
                else{
                    r--;
                }
            }
        }
    }
}