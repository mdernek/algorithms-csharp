namespace Algorithms.LinkedListSamples
{
    public interface ICycledLinkedList<T>
    {
        bool IsCycled();
    }

    public partial class LinkedList<T>: ICycledLinkedList<T>
    {
        public bool IsCycled(){
            Node<T> slow = this.GetNode();
            Node<T> fast = this.GetNode();

            while(slow != null && fast != null && fast.Next != null){
                slow = slow.Next;
                fast = fast.Next.Next;

                if(slow == fast){
                    return true;
                }
            }

            return false;
        }
    }
}