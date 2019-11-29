using Xunit;
using System.Collections.Generic;
using Algorithms.DataStructure;

namespace AlgorithmTests.DataStructure
{
    public class DisjointSetTest
    {
        [Fact]
        public void CreateDisjointSet(){
            char[] vertices = new char[] {'a','b','c','d','e'};
            (char, char)[] edges = new (char, char)[] {('c','a'), ('d','b')};
            char[][] resultDisjointSets = new char[][] {new char[] {'a','c'}, new char[] {'b','d'}, new char[] {'e'}};
            DisjointSet<char> disjointSet = new DisjointSet<char>(vertices);

            foreach((char u, char v) edge in edges){
                int? setUIndex = disjointSet.Find(edge.u);
                int? setVIndex = disjointSet.Find(edge.v);

                if(!setUIndex.Equals(setVIndex)){
                    disjointSet.Union(setUIndex, setVIndex);
                }
            }

            List<List<char>> sets = disjointSet.GetSets();

            int i=0;
            foreach(List<char> set in sets){
                if(set.Count > 0){
                    Assert.Equal(resultDisjointSets[i], set);
                    i++;
                }
            }
            
            Assert.Equal(resultDisjointSets.Length, i);
        }

        [Fact]
        public void CreateDisjointWithDifferentSet(){
            int[] vertices = new int[] {0,1,2,3,4,5,6,7,8,9};
            (int, int)[] edges = new (int, int)[] {(2,1), (4,3), (8,4), (9,3), (6,5)};
            int[][] resultDisjointSets = new int[][] {new int[] {0}, new int[] {1,2}, new int[] {3,4,8,9}, new int[] {5,6}, new int[] {7}};
            DisjointSet<int> disjointSet = new DisjointSet<int>(vertices);

            foreach((char u, char v) edge in edges){
                int? setUIndex = disjointSet.Find(edge.u);
                int? setVIndex = disjointSet.Find(edge.v);

                if(!setUIndex.Equals(setVIndex)){
                    disjointSet.Union(setUIndex, setVIndex);
                }
            }

            List<List<int>> sets = disjointSet.GetSets();

            int i=0;
            foreach(List<int> set in sets){
                if(set.Count > 0){
                    Assert.Equal(resultDisjointSets[i], set);
                    i++;
                }
            }
            
            Assert.Equal(resultDisjointSets.Length, i);
        }
    }
}