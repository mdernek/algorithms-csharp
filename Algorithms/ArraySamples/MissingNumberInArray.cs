using System;

namespace Algorithms.ArraySamples
{
    public class MissingNumberInArray
    {
        public int FindOneMissingNumber(int[] arr){
            if(arr.Length < 2){
                return -1;
            } 

            int n = arr.Length + 1;
            int totalCount = (n * (n+1))/2;

            foreach(int item in arr){
                totalCount -= item;
            }

            return totalCount;
        }

        public int FindOneMissingNumberInLargeArray(int[] arr){
            if(arr.Length < 2){
                return -1;
            }

            int totalCount = 1;

            for(int i=2; i<arr.Length+2; i++){
                totalCount += i;
                totalCount -= arr[i-2];
            }

            return totalCount;
        }

        public int FindOneMissingNumberWithXOR(int[] arr){
            if(arr.Length < 2){
                return -1;
            }

            int n = arr.Length;
            int x1 = arr[0];
            int x2 = 1;

            for(int i=1; i<n; i++){
                x1 = x1 ^ arr[i];
            }

            for(int i=2; i<n+2; i++){
                x2 = x2 ^ i;
            }

            return x1 ^ x2;
        }

        public int FindOneMissingNumberInOrderedArray(int[] arr){
            int l = 0;
            int r = arr.Length-1;

            while(l<=r){
                int m = (l+r)/2;

                if(arr[m] != m+1 && arr[m-1] == m){
                    return m+1;
                }
                else if(arr[m] != m+1){
                    r = m-1;
                }
                else {
                    l = m+1;
                }
            }

            return -1;
        }
    }
}