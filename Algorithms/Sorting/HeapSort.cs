namespace Algorithms.Sorting
{
    public class HeapSort
    {
        public void Sort(int[] arr){
            int n = arr.Length;
            for (int i = n/2; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for(int i=n-1; i>0; i--){
                Swap(arr, i, 0);
                Heapify(arr, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i){
            int largest = i;
            int l = 2*i + 1;
            int r = 2*i + 2;

            if(l<n && arr[l]>arr[largest]){
                largest = l;
            }

            if(r<n && arr[r]>arr[largest]){
                largest = r;
            }

            if(largest != i){
                Swap(arr, largest, i);
                Heapify(arr, n, largest);
            }
        }

        private void Swap(int[] arr, int i, int j){
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}