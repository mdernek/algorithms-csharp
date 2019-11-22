//https://www.java67.com/2014/02/how-to-find-largest-and-smallest-number-array-in-java.html?source=post_page---------------------------
using System;

namespace Algorithms.ArraySamples
{
    public class LargestAndSmallestNumbersInArray
    {
        public (int largest, int smallest) FindLargestAndSmallestNumbersInArray(int[] arr){
            if(arr.Length == 0){
                return (largest: -1, smallest: -1);
            }

            int largest = arr[0];
            int smallest = arr[0];

            for(int i=1; i<arr.Length; i++){
                if(arr[i]>largest){
                    largest = arr[i];
                }
                else if(arr[i]<smallest){
                    smallest = arr[i];
                }
            }

            return (largest: largest, smallest: smallest);
        }
    }
}