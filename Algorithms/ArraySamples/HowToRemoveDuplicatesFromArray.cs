//https://stackoverflow.com/questions/7961363/removing-duplicates-in-lists
using System.Collections.Generic;

namespace Algorithms.ArraySamples
{
    public class HowToRemoveDuplicatesFromArray
    {
        public IEnumerable<int> RemoveDuplicatesFromArray(int[] arr){
            HashSet<int> hashSet = new HashSet<int>();

            foreach(int item in arr){
                if(!hashSet.Contains(item)){
                    hashSet.Add(item);
                    yield return item;
                }
            }
        }
    }
}