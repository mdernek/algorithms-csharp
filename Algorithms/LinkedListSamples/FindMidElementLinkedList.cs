//https://www.geeksforgeeks.org/python-program-to-find-middle-of-a-linked-list-using-one-traversal/
namespace Algorithms.LinkedListSamples
{
    public interface IFindMidElementLinkedList<T>
    {
        T GetMidElement();
        T GetMidElementWithMode();
    }

    public partial class LinkedList<T>: IFindMidElementLinkedList<T>
    {
        public T GetMidElement(){
            Node<T> fast = this.GetNode();
            Node<T> slow = this.GetNode();

            while(fast != null && fast.Next != null){
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow.Data;
        }

        public T GetMidElementWithMode(){
            Node<T> current = this.GetNode();
            Node<T> mid = this.GetNode();
            int i=0;

            while(current.Next != null){
                current = current.Next;

                if(i % 2 == 1){
                    mid = mid.Next;
                }

                i++;
            }

            return mid.Data;
        }
    }
}