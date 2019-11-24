using System.Collections.Generic;

namespace Algorithms.LinkedListSamples
{
    public class CycleCheckLinkedList<T>: LinkedList<T>
    {
        public CycleCheckLinkedList(){}
        public CycleCheckLinkedList(IEnumerable<T> list): base(list) {}

        public bool IsCycled(){
            Node<T> slow = base.GetNode();
            Node<T> fast = base.GetNode();

            while(slow != null && fast != null && fast.next != null){
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast){
                    return true;
                }
            }

            return false;
        }
    }
}