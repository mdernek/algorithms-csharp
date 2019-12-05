namespace Algorithms.Sorting
{
    public class RadixSort
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

            int j = 1;

            while(k/j>0){
                CountingSort(arr, n, j);
                j *= 10;
            }
        }

        private void CountingSort(int[] arr, int n, int p){
            int k = 10;

            int[] count = new int[k];
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                int part = arr[i]/p%10; 
                count[part]++;
            }

            for (int i = 1; i < k; i++)
            {
                count[i] += count[i-1];
            }

            for(int i=n-1; i>=0; i--){
                int part = arr[i]/p%10;
                count[part]--;
                output[count[part]] = arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}