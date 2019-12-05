using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class BucketSort
    {
        public void Sort(float[] arr){
            int n = arr.Length;
            int multiplier = 10;
            List<List<float>> bucket = new List<List<float>>(multiplier);

            for (int i = 0; i < multiplier; i++)
            {
                bucket.Add(new List<float>());
            }

            for (int i = 0; i < n; i++)
            {
                int data = Convert.ToInt32(arr[i] * multiplier);
                bucket[data].Add(arr[i]);
            }

            for (int i = 0; i < multiplier; i++)
            {
                InsertionSort(bucket[i].ToArray());
            }

            int k = 0;
            for (int i = 0; i < multiplier; i++)
            {
                for (int j = 0; j < bucket[i].Count; j++)
                {
                    arr[k] = bucket[i][j];
                    k++;
                }
            }
        }

        private void InsertionSort(float[] arr){
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                float temp = arr[i];
                int j = i-1;

                while(j>=0 && arr[j]>temp){
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = temp;
            }
        }
    }
}