using Xunit;
using Algorithms.AbstractDataTypes;

namespace AlgorithmTests.AbstractDataTypes
{
    public class PriorityQueueTest
    {
        [Fact]
        public void CreatePriorityQueue(){
            IPriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(3, 3);
            priorityQueue.Enqueue(4, 4);
            priorityQueue.Enqueue(5, 5);
            priorityQueue.Enqueue(2, 2);
            priorityQueue.Enqueue(1, 1);
            priorityQueue.Enqueue(6, 6);
            priorityQueue.Enqueue(7, 7);
            Assert.Equal(7, priorityQueue.Count);
        }

        [Fact]
        public void CreatePriorityQueueDequeue(){
            IPriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(3, 3);
            priorityQueue.Enqueue(4, 4);
            priorityQueue.Enqueue(5, 5);
            priorityQueue.Enqueue(2, 2);
            priorityQueue.Enqueue(1, 1);
            priorityQueue.Enqueue(6, 6);
            priorityQueue.Enqueue(7, 7);
            
            Assert.Equal(1, priorityQueue.Dequeue());
            Assert.Equal(2, priorityQueue.Dequeue());
            Assert.Equal(3, priorityQueue.Dequeue());
            Assert.Equal(4, priorityQueue.Dequeue());
            Assert.Equal(5, priorityQueue.Dequeue());
            Assert.Equal(6, priorityQueue.Dequeue());
            Assert.Equal(7, priorityQueue.Dequeue());
        }

        [Fact]
        public void CreatePriorityQueueDequeueWithDifferentData(){
            IPriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(3, 4);
            priorityQueue.Enqueue(4, 8);
            priorityQueue.Enqueue(5, 7);
            priorityQueue.Enqueue(2, 12);
            priorityQueue.Enqueue(1, 6);
            priorityQueue.Enqueue(6, 3);
            priorityQueue.Enqueue(7, 1);
            
            Assert.Equal(6, priorityQueue.Dequeue());
            Assert.Equal(12, priorityQueue.Dequeue());
            Assert.Equal(4, priorityQueue.Dequeue());
            Assert.Equal(8, priorityQueue.Dequeue());
            Assert.Equal(7, priorityQueue.Dequeue());
            Assert.Equal(3, priorityQueue.Dequeue());
            Assert.Equal(1, priorityQueue.Dequeue());
        }

        [Fact]
        public void CreatePriorityQueueWithNoData(){
            IPriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            
            Assert.Equal(0, priorityQueue.Dequeue());
        }
    }
}