using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.ArraySamples
{
    public class MaxSubArray
    {
        public int GetMaxSubArrayCount(int[] arr){
            int sum = 0;
            int maxSum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                var num = arr[i];
                sum += num;

                if(num > sum){
                    sum = num;
                }

                if(sum > maxSum){
                    maxSum = sum;
                }
            }

            return maxSum;
        }   
    }
}
