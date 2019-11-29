namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public int Search(int[] arr, int k){
            int n = arr.Length;
            int l = 0;
            int r = n-1;

            while(l<=r){
                int mid = (l+r)/2;

                if(arr[mid] == k){
                    return mid;
                }
                else if(arr[mid] > k){
                    r = mid+1;
                }
                else{
                    l = mid+1;
                }
            }

            return -1;
        }
    }
}