using Xunit;
using System.Collections.Generic;
using Algorithms.DataStructure;

namespace AlgorithmTests.DataStructure
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void CreateBinarySearchTree(){
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(80);

            Assert.Equal(7, binarySearchTree.Count);
        }

        [Fact]
        public void GetKeyInOrderBinarySearchTree(){
            int[] arr = new int[] {20, 30, 40, 50, 60, 70, 80};
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(80);

            IEnumerable<int> keys = binarySearchTree.GetKeysInOrder();
            int i=0;

            foreach(int key in keys){
                Assert.Equal(arr[i], key);
                i++;
            }

            Assert.Equal(7, i);
        }

        [Fact]
        public void DeleteKeyFromLeafBinarySearchTree(){
            int[] arr = new int[] {50, 30, 40, 70, 60, 65, 80};
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(80);

            binarySearchTree.DeleteKey(20);
            IEnumerable<int> keys = binarySearchTree.GetKeysPreOrder();
            int i=0;

            foreach(int key in keys){
                Assert.Equal(arr[i], key);
                i++;
            }

            Assert.Equal(7, i);
        }

        [Fact]
        public void DeleteKeyOnlyOneChildBinarySearchTree(){
            int[] arr = new int[] {50, 40, 70, 60, 65, 80};
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(80);

            binarySearchTree.DeleteKey(30);
            IEnumerable<int> keys = binarySearchTree.GetKeysPreOrder();
            int i=0;

            foreach(int key in keys){
                Assert.Equal(arr[i], key);
                i++;
            }

            Assert.Equal(6, i);
        }

        [Fact]
        public void DeleteKeyHasTwoChildrenBinarySearchTree(){
            int[] arr = new int[] {60, 30, 20, 40, 70, 65, 80};
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(80);

            binarySearchTree.DeleteKey(50);
            IEnumerable<int> keys = binarySearchTree.GetKeysPreOrder();
            int i=0;

            foreach(int key in keys){
                Assert.Equal(arr[i], key);
                i++;
            }

            Assert.Equal(7, i);
        }
    }
}