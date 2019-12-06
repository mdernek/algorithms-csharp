using System.Collections.Generic;

namespace Algorithms.AbstractDataTypes
{
    public interface IPriorityQueue<T>
    {
        void Enqueue(int priority, T data);
        QueueItem<T> Dequeue();
        int Count{ get; }
    }

    public class QueueItem<T> {
        public int Priority {get; private set;}
        public T Data { get; private set; }

        public QueueItem(int priority, T data){
            this.Priority = priority;
            this.Data = data;
        }
    }
        
    public class PriorityQueue<T> : IPriorityQueue<T>
    {
        List<QueueItem<T>> _priorityQueue;
        public int Count { 
            get {
                return this._priorityQueue.Count;
            }
        }

        public PriorityQueue(){
            _priorityQueue = new List<QueueItem<T>>();
        }

        public QueueItem<T> Dequeue()
        {
            if(Count < 1){
                return default(QueueItem<T>);
            }

            QueueItem<T> node = this._priorityQueue[0];
            this.swap(0, Count-1);
            this._priorityQueue.RemoveAt(Count-1);

            for(int i=Count/2;i>=0;i--){
                Heapify(Count, i);
            }

            return node;
        }

        public void Enqueue(int priority, T data)
        {
            QueueItem<T> node = new QueueItem<T>(priority, data);
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
            QueueItem<T> temp = this._priorityQueue[i];
            this._priorityQueue[i] = this._priorityQueue[j];
            this._priorityQueue[j] = temp;
        }
    }
}