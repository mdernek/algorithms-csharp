using System.Collections.Generic;
using Algorithms.DataStructure;
using Algorithms.AbstractDataTypes;

namespace Algorithms.GraphAlgorithms
{
    public class Kruskal<T>
    {
        DisjointSet<T> _disjointSet;
        PriorityQueue<(T u, T v)> _priorityQueue;

        public Kruskal(T[] vertices){
            _disjointSet = new DisjointSet<T>(vertices);
            _priorityQueue = new PriorityQueue<(T u, T v)>();
        }

        public void AddEdges(int weight, (T u, T v) edges){
            _priorityQueue.Enqueue(weight, edges);
        }

        public List<QueueItem<(T u, T v)>> ExecuteKruskal(){
            List<QueueItem<(T u, T v)>> result = new List<QueueItem<(T u, T v)>>();

            while(_priorityQueue.Count > 0){
                QueueItem<(T u, T v)> queueItem = _priorityQueue.Dequeue();
                int? setUIndex = _disjointSet.Find(queueItem.Data.u);
                int? setVIndex = _disjointSet.Find(queueItem.Data.v);

                if(setUIndex != setVIndex){
                    result.Add(queueItem);
                    _disjointSet.Union(setUIndex, setVIndex);
                }
            }

            return result;
        }
    }
}