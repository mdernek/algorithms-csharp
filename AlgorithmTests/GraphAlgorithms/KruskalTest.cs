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
            List<(int, char, char)> actualResult = new List<(int, char, char)>();
            actualResult.Add((1, 'a', 'b'));
            actualResult.Add((1, 'c', 'd'));
            actualResult.Add((2, 'b', 'd'));

            Kruskal<char> kruskal = new Kruskal<char>(vertices);
            kruskal.AddEdges(1, ('a', 'b'));
            kruskal.AddEdges(5, ('a', 'c'));
            kruskal.AddEdges(3, ('a', 'd'));
            kruskal.AddEdges(4, ('b', 'c'));
            kruskal.AddEdges(2, ('b', 'd'));
            kruskal.AddEdges(1, ('c', 'd'));

            List<QueueItem<(char u, char v)>> result = kruskal.ExecuteKruskal();

            Assert.Equal(3, result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.Equal(actualResult[i], (result[i].Priority, result[i].Data.u, result[i].Data.v));
            }
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