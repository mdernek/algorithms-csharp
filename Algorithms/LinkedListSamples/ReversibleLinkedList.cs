using System.Collections.Generic;

namespace Algorithms.LinkedListSamples
{
    public class ReversibleLinkedList<T>: LinkedList<T>
    {
        public ReversibleLinkedList(IEnumerable<T> list): base(list) {}

        public void reverse(){
            Node<T> head = base.GetNode();
            
            if(head is null){
                return;
            }

            Node<T> tail = head;
            tail.next = null;
            head = head.next;
            Node<T> reversedNode = tail;

            while(head != null && head.next != null){
                Node<T> temp = head.next;
                temp.next = reversedNode;
                reversedNode = temp;
            }
        }
    }
}