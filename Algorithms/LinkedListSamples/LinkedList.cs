using System.Collections.Generic;

namespace Algorithms.LinkedListSamples
{
    public interface ILinkedList<T>
    {
        void Add(T data);
        void Add(Node<T> node);
        Node<T> GetNode();
        IEnumerable<T> GetList();
    }

    public partial class LinkedList<T>: ILinkedList<T>
    {
        Node<T> head = null;
        Node<T> tail = null;

        public LinkedList(){}
        public LinkedList(IEnumerable<T> list){
            if(list is null){
                return;
            }

            foreach(T item in list){
                Add(item);
            }
        }

        public void Add(T data){
            Node<T> node = new Node<T>(data);
            Add(node);
        }

        public void Add(Node<T> node){
            if(tail != null){
                node.Previous = tail;
                tail.Next = node;
            }

            if(head is null){
                head = node;
            }

            tail = node;
        }

        public Node<T> GetNode(){
            return head;
        }

        public IEnumerable<T> GetList(){
            Node<T> node = GetNode();

            while(node != null && node.Next != null){
                T data = node.Data;
                node = node.Next;
                yield return data;
            }
        }
    }
}