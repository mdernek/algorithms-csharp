namespace Algorithms.Sorting
{
    public class CountingSort
    {
        public void Sort(int[] arr){
            int n = arr.Length;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if(arr[i]>k){
                    k = arr[i];
                }
            }

            int[] count = new int[k+1];
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }

            for (int i = 1; i < k+1; i++)
            {
                count[i] += count[i-1];
            }

            for(int i=n-1;i>=0;i--){
                count[arr[i]]--;
                output[count[arr[i]]] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}