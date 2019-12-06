using System.Collections.Generic;
using Xunit;
using Algorithms.GraphAlgorithms;

namespace AlgorithmTests.GraphAlgorithms
{
    public class PrimTest
    {
        [Fact]
        public void PrimWithGraph(){
            char[] vertices = new char[] {'a','b','c','d'};
            List<(int weight, char u, char v)> actualResult = new List<(int weight, char u, char v)>();
            actualResult.Add((1,'a','b'));
            actualResult.Add((1,'d','c'));
            actualResult.Add((2,'b','d'));

            Prim<char> prim = new Prim<char>(vertices);
            prim.AddEdge(1, 'a', 'b');
            prim.AddEdge(5, 'a', 'c');
            prim.AddEdge(3, 'a', 'd');
            prim.AddEdge(4, 'b', 'c');
            prim.AddEdge(2, 'b', 'd');
            prim.AddEdge(1, 'c', 'd');

            List<(int weight, char u, char v)>  result = prim.ExecutePrim('a');

            Assert.Equal(3, result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.Equal(actualResult[i], result[i]);
            }
        }

        [Fact]
        public void PrimWithEmptyGraph(){
            char[] vertices = new char[] {};
            Prim<char> prim = new Prim<char>(vertices);
            List<(int weight, char u, char v)>  result = prim.ExecutePrim('a');
            Assert.Equal(0, result.Count);
        }
    }
}