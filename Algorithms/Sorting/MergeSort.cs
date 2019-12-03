namespace Algorithms.Sorting
{
    public class MergeSort
    {
        int[] _clonedArr;

        public MergeSort(){
            _clonedArr = null;
        }

        public void Sort(int[] arr){
            _clonedArr = (int[])arr.Clone();
            int start = 0;
            int end = arr.Length-1;
            Sort(arr, start, end);
        }

        private void Sort(int[] arr, int start, int end){
            if(start>=end){
                return;
            }

            int mid = (start+end)/2;
            Sort(arr, start, mid);
            Sort(arr, mid+1, end);
            Merge(arr, start, mid, end);

            for (int i = start; i <= end; i++)
            {
                arr[i] = _clonedArr[i];
            }
        }

        private void Merge(int[] arr, int start, int mid, int end){
            int i = start;
            int k = start;
            int j = mid + 1;

            while(i<=mid && j<=end){
                if(arr[i]<arr[j]){
                    _clonedArr[k] = arr[i];
                    i++;
                }
                else{
                    _clonedArr[k] = arr[j];
                    j++;
                }

                k++;
            }

            if(i>mid){
                while(j<=mid){
                    _clonedArr[k] = arr[j];
                    j++;
                    k++;
                }
            }
            else{
                while(i<=mid){
                    _clonedArr[k] = arr[i];
                    i++;
                    k++;
                }
            }
        }
    }
}