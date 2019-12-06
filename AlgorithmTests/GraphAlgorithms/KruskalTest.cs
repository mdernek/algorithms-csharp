using System.Collections.Generic;
using Xunit;
using Algorithms.GraphAlgorithms;
using Algorithms.AbstractDataTypes;

namespace AlgorithmTests.GraphAlgorithms
{
    public class KruskalTest
    {
        [Fact]
        public void KruskalWithGraph(){
            char[] vertices = new char[] {'a','b','c','d','e','f'};
            Kruskal<char> kruskal = new Kruskal<char>(vertices);
            kruskal.AddEdges(1, ('a', 'b'));
            kruskal.AddEdges(5, ('a', 'c'));
            kruskal.AddEdges(3, ('a', 'd'));
            kruskal.AddEdges(4, ('b', 'c'));
            kruskal.AddEdges(2, ('b', 'd'));
            kruskal.AddEdges(1, ('c', 'd'));

            List<QueueItem<(char u, char v)>> result = kruskal.ExecuteKruskal();

            Assert.Equal((1, 'a', 'b'), (result[0].Priority, result[0].Data.u, result[0].Data.v));
            Assert.Equal((1, 'c', 'd'), (result[1].Priority, result[1].Data.u, result[1].Data.v));
            Assert.Equal((2, 'b', 'd'), (result[2].Priority, result[2].Data.u, result[2].Data.v));
        }

        [Fact]
        public void KruskalWithEmptyGraph(){
            char[] vertices = new char[] {};
            Kruskal<char> kruskal = new Kruskal<char>(vertices);

            List<QueueItem<(char u, char v)>> result = kruskal.ExecuteKruskal();

            Assert.Equal(0, result.Count);
        }
    }
}