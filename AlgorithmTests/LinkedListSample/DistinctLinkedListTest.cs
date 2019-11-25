using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class DistinctLinkedListTest
    {
        [Fact]
        public void LinkedListDistinctNode(){
            int[] arr = new int[] {1, 2, 3, 2, 4, 4, 5, 5, 5, 6, 6};
            int[] distinctArr = new int[] {1, 2, 3, 4, 5, 6};
            LinkedList<int> linkedList = new LinkedList<int>(arr);
            IDistinctLinkedList<int> distinctLinkedList = linkedList as IDistinctLinkedList<int>;
            distinctLinkedList.MakeDistinct();

            int i=0;
            foreach(int item in linkedList.GetList()){
                Assert.Equal(distinctArr[i], item);
                i++;
            }
        }

        [Fact]
        public void LinkedListDistinctNodeWithNullObject(){
            ILinkedList<int> linkedList = new LinkedList<int>(null);
            
            IReversibleLinkedList<int> reversibleLinkedList = linkedList as IReversibleLinkedList<int>;
            reversibleLinkedList.reverse();

            int i = 0;
            foreach(int item in linkedList.GetList()){
                i++;
            }

            Assert.Equal(0, i);
        }
    }
}