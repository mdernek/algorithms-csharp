namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        public void Sort(int[] arr){
            int n = arr.Length;

            for (int i = 0; i < n-1; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < n-1-i; j++)
                {
                    if(arr[j]>arr[j+1]){
                        Swap(arr, j, j+1);
                        isSwapped = true;
                    }
                }

                if(!isSwapped){
                    break;
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