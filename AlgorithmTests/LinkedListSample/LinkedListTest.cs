using System;
using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class LinkedListTest
    {
        [Fact]
        public void LinkedListCreationWithArray(){
            int[] arr = new int[] {1,2,3,4,5,6};
            LinkedList<int> linkedList = new LinkedList<int>(arr);

            int i = 0;
            foreach(int item in linkedList.GetList()){
                Assert.Equal(arr[i], item);
                i++;
            }
        }

        [Fact]
        public void LinkedListCreationWithNullObject(){
            LinkedList<int> linkedList = new LinkedList<int>(null);

            int i = 0;
            foreach(int item in linkedList.GetList()){
                i++;
            }

            Assert.Equal(0, i);
        }

        [Fact]
        public void LinkedListCreationOneByOne(){
            int[] arr = new int[] {1,2,3,4,5,6};
            LinkedList<int> linkedList = new LinkedList<int>();
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

        [Fact]
        public void LinkedListReverese(){
            int[] arr = new int[] {1,2,3,4,5,6};
            int[] reversedArr = new int[] {6,5,4,3,2,1};
            ReversibleLinkedList<int> reversibleLinkedList = new ReversibleLinkedList<int>(arr);
            reversibleLinkedList.reverse();
            

            int i = 0;
            foreach(int item in reversibleLinkedList.GetList()){
                Assert.Equal(reversedArr[i], item);
                i++;
            }
        }

        [Fact]
        public void LinkedListRevereseWithNullObject(){
            ReversibleLinkedList<int> reversibleLinkedList = new ReversibleLinkedList<int>(null);
            reversibleLinkedList.reverse();

            int i = 0;
            foreach(int item in reversibleLinkedList.GetList()){
                i++;
            }

            Assert.Equal(0, i);
        }
    }
}