using System;

namespace Algorithms.Sorting
{
    public class QuickSort
    {

        Random _random;

        public QuickSort()
        {
            _random = new Random();
        }

        public void Sort(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            Sort(arr, start, end);
        }

        private void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = RandomPartition(arr, start, end);
                Sort(arr, start, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, end);
            }
        }

        private int RandomPartition(int[] arr, int start, int end)
        {
            int rnd = _random.Next(start, end);
            Swap(arr, rnd, start);
            return Partition(arr, start, end);
        }

        private int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int lb = start;
            int ub = end;

            while (lb < ub)
            {
                while (lb < end && arr[lb] <= pivot)
                {
                    lb++;
                }

                while (ub > start && arr[ub] >= pivot)
                {
                    ub--;
                }

                if (lb < ub)
                {
                    Swap(arr, lb, ub);
                }
            }

            Swap(arr, start, ub);

            return ub;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}