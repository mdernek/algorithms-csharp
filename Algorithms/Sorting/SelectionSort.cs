namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public void Sort(int[] arr){
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i+1; j < n; j++)
                {
                    if(arr[min]>arr[j]){
                        min = j;
                    }
                }

                if(min != i){
                    Swap(arr, min, i);
                }
            }
        }

        private void Swap(int[] arr, int i, int j){
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}