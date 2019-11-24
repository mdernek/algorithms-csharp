using System.Collections.Generic;

namespace Algorithms.LinkedListSamples
{
    public class LinkedList<T>
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
                tail.next = node;
            }

            if(head is null){
                head = node;
            }

            tail = node;
        }

        public virtual Node<T> GetNode(){
            return head;
        }

        public IEnumerable<T> GetList(){
            Node<T> node = GetNode();

            while(node != null && node.next != null){
                T data = node.data;
                node = node.next;
                yield return data;
            }
        }
    }
}