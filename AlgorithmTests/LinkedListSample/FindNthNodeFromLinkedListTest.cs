using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class FindNthNodeFromLinkedListTest
    {
        [Fact]
        public void FindNthNodeFromLinkedList(){
            int[] arr = new int[] {1,2,3,4,5,6};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);

            IFindNthNodeFromLinkedList<int> findNthNode = linkedList as IFindNthNodeFromLinkedList<int>;
            int nthNode = findNthNode.GetNthNodeFromEnd(2);

            Assert.Equal(5, nthNode);
        }

        [Fact]
        public void FindNthNodeFromLinkedListWithEmptyArray(){
            int[] arr = new int[] {};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);

            IFindNthNodeFromLinkedList<int> findNthNode = linkedList as IFindNthNodeFromLinkedList<int>;
            int nthNode = findNthNode.GetNthNodeFromEnd(2);

            Assert.Equal(0, nthNode);
        }

        [Fact]
        public void FindNthNodeFromLinkedListWithBiggerNthThanArray(){
            int[] arr = new int[] {1,2,3,4,5,6};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);

            IFindNthNodeFromLinkedList<int> findNthNode = linkedList as IFindNthNodeFromLinkedList<int>;
            int nthNode = findNthNode.GetNthNodeFromEnd(7);

            Assert.Equal(0, nthNode);
        }
    }
}