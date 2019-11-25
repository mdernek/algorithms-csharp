using System.Collections.Generic;

namespace Algorithms.AbstractDataTypes
{
    public interface IPriorityQueue<T>
    {
        void Enqueue(int priority, T data);
        T Dequeue();
        int Count{ get; }
    }
    public partial class PriorityQueue<T> : IPriorityQueue<T>
    {
        List<Node> _priorityQueue;
        public int Count { 
            get {
                return this._priorityQueue.Count;
            }
        }

        public PriorityQueue(){
            _priorityQueue = new List<Node>();
        }

        public T Dequeue()
        {
            if(Count < 1){
                return default(T);
            }

            T data= this._priorityQueue[0].Data;
            this.swap(0, Count-1);
            this._priorityQueue.RemoveAt(Count-1);

            for(int i=Count/2;i>=0;i--){
                Heapify(Count, i);
            }

            return data;
        }

        public void Enqueue(int priority, T data)
        {
            Node node = new Node(priority, data);
            this._priorityQueue.Add(node);

            if(Count > 1){
                for(int i=Count/2;i>=0;i--){
                    this.Heapify(Count, i);
                }
            }
        }

        private void Heapify(int n, int i){
            int smallest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if(l<n && this._priorityQueue[l].Priority < this._priorityQueue[smallest].Priority){
                smallest = l;
            }

            if(r<n && this._priorityQueue[r].Priority < this._priorityQueue[smallest].Priority){
                smallest = r;
            }

            if(smallest != i){
                this.swap(smallest, i);
                Heapify(n, smallest);
            }
        }

        private void swap(int i, int j){
            Node temp = this._priorityQueue[i];
            this._priorityQueue[i] = this._priorityQueue[j];
            this._priorityQueue[j] = temp;
        }
    }

    public partial class PriorityQueue<T> {
        class Node {
            public int Priority {get; private set;}
            public T Data { get; private set; }

            public Node(int priority, T data){
                this.Priority = priority;
                this.Data = data;
            }
        }
    }
}