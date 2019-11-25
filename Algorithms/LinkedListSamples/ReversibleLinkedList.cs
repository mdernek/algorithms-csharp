
namespace Algorithms.LinkedListSamples
{
    public interface IReversibleLinkedList<T>
    {
        void reverse();
    }
    public partial class LinkedList<T>: IReversibleLinkedList<T>
    {
        public void reverse(){
            Node<T> head = this.GetNode();
            
            if(head is null){
                return;
            }

            Node<T> tail = head;
            tail.Next = null;
            head = head.Next;
            Node<T> reversedNode = tail;

            while(head != null && head.Next != null){
                Node<T> temp = head.Next;
                temp.Next = reversedNode;
                reversedNode = temp;
            }
        }
    }
}