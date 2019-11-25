using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class ReversibleLinkedListTest
    {
        [Fact]
        public void LinkedListReverese(){
            int[] arr = new int[] {1,2,3,4,5,6};
            int[] reversedArr = new int[] {6,5,4,3,2,1};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);

            IReversibleLinkedList<int> reversibleLinkedList = linkedList as IReversibleLinkedList<int>;
            reversibleLinkedList.reverse();

            int i = 0;
            foreach(int item in linkedList.GetList()){
                Assert.Equal(reversedArr[i], item);
                i++;
            }
        }

        [Fact]
        public void LinkedListRevereseTestWithNullObject(){
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