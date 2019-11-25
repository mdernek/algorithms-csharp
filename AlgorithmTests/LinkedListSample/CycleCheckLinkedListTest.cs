using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class CycleCheckLinkedListTest
    {
        [Fact]
        public void LinkedListIsNotCycled(){
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            linkedList.Add(new Node<int>(3));
            linkedList.Add(new Node<int>(4));
            linkedList.Add(new Node<int>(5));
            linkedList.Add(new Node<int>(6));

            ICycledLinkedList<int> cycledLinkedList = linkedList as ICycledLinkedList<int>;
            bool isCycled = cycledLinkedList.IsCycled();
            Assert.False(isCycled);
        }

        [Fact]
        public void LinkedListIsCycled(){
            ILinkedList<int> linkedList = new LinkedList<int>();
            Node<int> cycledNode = new Node<int>(2);
            linkedList.Add(new Node<int>(1));
            linkedList.Add(cycledNode);
            linkedList.Add(new Node<int>(3));
            linkedList.Add(new Node<int>(4));
            linkedList.Add(new Node<int>(5));
            linkedList.Add(cycledNode);

            ICycledLinkedList<int> cycledLinkedList = linkedList as ICycledLinkedList<int>;
            bool isCycled = cycledLinkedList.IsCycled();
            Assert.True(isCycled);
        }
    }
}