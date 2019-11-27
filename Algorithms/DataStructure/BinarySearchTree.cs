//https://www.geeksforgeeks.org/binary-search-tree-set-1-search-and-insertion/
//https://www.geeksforgeeks.org/binary-search-tree-set-2-delete/
using System.Collections.Generic;

namespace Algorithms.DataStructure
{
    public partial class BinarySearchTree
    {
        Node _root = null;
        public int Count { get; private set; }

        public void Insert(int key){
            _root = InsertNode(_root, key);
        }

        private Node InsertNode(Node root, int key){
            if(root is null){
                root = new Node(key);
                Count++;
                return root;
            }

            if(key < root.key){
                root.left = InsertNode(root.left, key);
            }
            else {
                root.right = InsertNode(root.right, key);
            }

            return root;
        }

        public IEnumerable<int> GetKeysInOrder(){
            foreach(int key in GetNodeKeysInOrder(_root)){
                yield return key;
            }
        }

        private IEnumerable<int> GetNodeKeysInOrder(Node root){
            if(root is null) yield break;

            foreach(int key in GetNodeKeysInOrder(root.left)){
                yield return key;
            }
            
            yield return root.key;
            
            foreach(int key in GetNodeKeysInOrder(root.right)){
                yield return key;
            }
        }

        public IEnumerable<int> GetKeysPreOrder(){
            foreach(int key in GetNodeKeysPreOrder(_root)){
                yield return key;
            }
        }

        private IEnumerable<int> GetNodeKeysPreOrder(Node root){
            if(root is null) yield break;

            yield return root.key;

            foreach(int key in GetNodeKeysPreOrder(root.left)){
                yield return key;
            }
            
            foreach(int key in GetNodeKeysPreOrder(root.right)){
                yield return key;
            }
        }

        public void DeleteKey(int key){
            _root = DeleteNode(_root, key);
        }

        private Node DeleteNode(Node root, int key){
            if(root is null) return null;

            if(root.key == key){
                //One of the children is empty
                if(root.left is null){
                    return root.right;
                }
                else if(root.right is null){
                    return root.left;
                }
                //Both children exist
                else {
                    Node nodeParent = root.right;
                    Node node = root.right;

                    //Find the smallest key in the right subtree
                    //It's the deepest left side
                    while(node.left != null){
                        nodeParent = node;
                        node = node.left;
                    }

                    //We can safely make successor's right 
                    //Right child as left of its parent.
                    nodeParent.left = node.right;
                    root.key = node.key;
                }
            }
            else if(key < root.key){
                root.left = DeleteNode(root.left, key);
            }
            else {
                root.right = DeleteNode(root.right, key);
            }

            return root;
        }
    }

    public partial class BinarySearchTree {
        class Node {
            public int key;
            public Node left;
            public Node right;

            public Node(int key){
                this.key = key;
            }
        }
    }
}