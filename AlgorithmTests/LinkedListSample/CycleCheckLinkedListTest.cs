using System;
using Xunit;
using Algorithms.LinkedListSamples;

namespace AlgorithmTests.LinkedListSample
{
    public class CycleCheckLinkedListTest
    {
        [Fact]
        public void LinkedListIsNotCycled(){
            CycleCheckLinkedList<int> cycleCheckLinkedList = new CycleCheckLinkedList<int>();
            cycleCheckLinkedList.Add(new Node<int>(1));
            cycleCheckLinkedList.Add(new Node<int>(2));
            cycleCheckLinkedList.Add(new Node<int>(3));
            cycleCheckLinkedList.Add(new Node<int>(4));
            cycleCheckLinkedList.Add(new Node<int>(5));
            cycleCheckLinkedList.Add(new Node<int>(6));

            bool isCycled = cycleCheckLinkedList.IsCycled();
            Assert.False(isCycled);
        }

        [Fact]
        public void LinkedListIsCycled(){
            CycleCheckLinkedList<int> cycleCheckLinkedList = new CycleCheckLinkedList<int>();
            Node<int> cycledNode = new Node<int>(2);
            cycleCheckLinkedList.Add(new Node<int>(1));
            cycleCheckLinkedList.Add(cycledNode);
            cycleCheckLinkedList.Add(new Node<int>(3));
            cycleCheckLinkedList.Add(new Node<int>(4));
            cycleCheckLinkedList.Add(new Node<int>(5));
            cycleCheckLinkedList.Add(cycledNode);

            bool isCycled = cycleCheckLinkedList.IsCycled();
            Assert.True(isCycled);
        }
    }
}