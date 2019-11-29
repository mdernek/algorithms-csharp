#nullable enable
using System.Collections.Generic;

namespace Algorithms.DataStructure
{
    public class DisjointSet<T> where T: notnull
    {
        T[] _vertices;
        Dictionary<T, int> _vIndex;
        List<List<T>> _sets;
        public DisjointSet(T[] vertices){
            _vertices = vertices;
            _vIndex = new Dictionary<T, int>();
            _sets = new List<List<T>>();

            for(int i=0; i<vertices.Length; i++){
                _sets.Add(new List<T>(){vertices[i]});

                if(!_vIndex.ContainsKey(vertices[i])) {
                    _vIndex.Add(vertices[i], i);
                }
            }
        }

        public int? Find(T vertex){
            if(_vIndex.ContainsKey(vertex)){
                return _vIndex[vertex];
            }

            return null;
        }

        public void Union(int? setUIndex, int? setVIndex){
            if(!setUIndex.HasValue || !setVIndex.HasValue){
                return;
            }

            _sets[setVIndex.Value].AddRange(_sets[setUIndex.Value]);

            foreach(T vertex in _sets[setUIndex.Value]){
                _vIndex[vertex] = setVIndex.Value;
            }

            _sets[setUIndex.Value] = new List<T>();
        }

        public List<List<T>> GetSets(){
            return _sets;
        }
    }
}