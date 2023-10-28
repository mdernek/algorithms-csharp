namespace Algorithms.ArraySamples
{
    public class CircularArraySearch
    {
        public static int circularArraySearchInArray(int[] arr, int k)
        {
            //Sample Arraty: int[] arr = { 8, 9, 10, 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == k)
                {
                    return mid;
                }
                else if (arr[mid] <= arr[high])
                {
                    if (k > arr[mid] && k <= arr[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    if (k >= arr[low] && k < arr[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}