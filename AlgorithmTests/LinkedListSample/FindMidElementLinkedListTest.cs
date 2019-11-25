using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class FindMidElementLinkedListTest
    {
        [Fact]
        public void FindMidElementWithOddNumberList(){
            int[] arr = new int[] {1,20,100,15,35,45,85};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);
            IFindMidElementLinkedList<int> findMidElement = linkedList as IFindMidElementLinkedList<int>;

            int midElement = findMidElement.GetMidElement();
            Assert.Equal(15, midElement);
        }

        [Fact]
        public void FindMidElementWithEvenNumberList(){
            int[] arr = new int[] {1,20,100,35,45,85};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);
            IFindMidElementLinkedList<int> findMidElement = linkedList as IFindMidElementLinkedList<int>;
            
            int midElement = findMidElement.GetMidElement();
            Assert.Equal(35, midElement);
        }

        [Fact]
        public void FindMidElementWithModeWithOddNumberList(){
            int[] arr = new int[] {1,20,100,15,35,45,85};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);
            IFindMidElementLinkedList<int> findMidElement = linkedList as IFindMidElementLinkedList<int>;

            int midElement = findMidElement.GetMidElementWithMode();
            Assert.Equal(15, midElement);
        }

        [Fact]
        public void FindMidElementWithModeWithEvenNumberList(){
            int[] arr = new int[] {1,20,100,35,45,85};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);
            IFindMidElementLinkedList<int> findMidElement = linkedList as IFindMidElementLinkedList<int>;
            
            int midElement = findMidElement.GetMidElementWithMode();
            Assert.Equal(100, midElement);
        }
    }
}