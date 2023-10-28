namespace Algorithms.ArraySamples
{
    public class FindRotationCount
    {
        public int FindRotationCountInArray(int[] arr)
        {
            //Sample arr: int[] arr = { 8, 9, 10, 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                if (arr[low] < arr[high])
                {
                    return low;
                }

                int mid = (low + high) / 2;
                int next = (mid + 1) % n;
                int prev = (mid + n - 1) % n;

                if (arr[mid] <= arr[next] && arr[mid] <= arr[prev])
                {
                    return mid;
                }
                else if (arr[mid] <= arr[high])
                {
                    high = mid - 1;
                }
                else if (arr[mid] >= arr[low])
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}