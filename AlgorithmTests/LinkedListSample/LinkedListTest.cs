using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class LinkedListTest
    {
        [Fact]
        public void LinkedListCreationWithArray(){
            int[] arr = new int[] {1,2,3,4,5,6};
            ILinkedList<int> linkedList = new LinkedList<int>(arr);

            int i = 0;
            foreach(int item in linkedList.GetList()){
                Assert.Equal(arr[i], item);
                i++;
            }
        }

        [Fact]
        public void LinkedListCreationWithNullObject(){
            ILinkedList<int> linkedList = new LinkedList<int>(null);

            int i = 0;
            foreach(int item in linkedList.GetList()){
                i++;
            }

            Assert.Equal(0, i);
        }

        [Fact]
        public void LinkedListCreationOneByOne(){
            int[] arr = new int[] {1,2,3,4,5,6};
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            int i = 0;
            foreach(int item in linkedList.GetList()){
                Assert.Equal(arr[i], item);
                i++;
            }
        }
    }
}