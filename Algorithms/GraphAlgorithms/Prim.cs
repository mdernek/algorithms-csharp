using System.Collections.Generic;
using Algorithms.AbstractDataTypes;

namespace Algorithms.GraphAlgorithms
{
    public class Prim<T>
    {
        T[] _vertices;
        Dictionary<T, T> _parent;
        Dictionary<T, bool> _visited;
        Dictionary<T, int> _distance;
        Dictionary<T, List<(int weight, T vertex)>> _edges;
        PriorityQueue<T> _priorityQueue;

        public Prim(T[] vertices){
            _vertices = vertices;
            _parent = new Dictionary<T, T>();
            _visited = new Dictionary<T, bool>();
            _distance = new Dictionary<T, int>();
            _edges = new Dictionary<T, List<(int weight, T vertex)>>();
            _priorityQueue = new PriorityQueue<T>();

            foreach(T vertex in vertices){
                _parent[vertex] = default(T);
                _distance[vertex] = int.MaxValue;
                _visited[vertex] = false;
            }
        }

        public void AddEdge(int weight, T u, T v){
            if(!_edges.ContainsKey(u)){
                _edges[u] = new List<(int weight, T vertex)>();
                _edges[u].Add((weight, v));
            }
            else {
                _edges[u].Add((weight, v));
            }

            if(!_edges.ContainsKey(v)){
                _edges[v] = new List<(int weight, T vertex)>();
                _edges[v].Add((weight, u));
            }
            else {
                _edges[v].Add((weight, u));
            }
        }

        public List<(int weight, T u, T v)> ExecutePrim(T source){
            List<(int weight, T u, T v)> result = new List<(int weight, T u, T v)>();

            _distance[source] = 0;
            foreach (T vertex in _vertices)
            {
                _priorityQueue.Enqueue(_distance[vertex], vertex);   
            }

            while(_priorityQueue.Count > 0){
                QueueItem<T> queueItem = _priorityQueue.Dequeue();

                if(!_visited[queueItem.Data]){
                    _visited[queueItem.Data] = true;
                }
                else{
                    continue;
                }

                foreach ((int weight, T vertex) edge in _edges[queueItem.Data])
                {
                    if(!_visited[edge.vertex] && edge.weight < _distance[edge.vertex]){
                        _distance[edge.vertex] = edge.weight;
                        _parent[edge.vertex] = queueItem.Data;
                        _priorityQueue.Enqueue(edge.weight, edge.vertex);
                    }
                }
            }

            foreach (T vertex in _vertices)
            {
                if(!EqualityComparer<T>.Default.Equals(_parent[vertex], default(T))){
                    result.Add((_distance[vertex], _parent[vertex], vertex));
                }
            }

            return result;
        }
    }
}