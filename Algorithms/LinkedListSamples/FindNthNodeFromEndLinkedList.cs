namespace Algorithms.LinkedListSamples
{

    public interface IFindNthNodeFromLinkedList<T>
    {
        T GetNthNodeFromEnd(int k);
    }
    public partial class LinkedList<T>: IFindNthNodeFromLinkedList<T>
    {
        public T GetNthNodeFromEnd(int k){
            Node<T> node = this.GetNode();
            Node<T> slow = this.GetNode();
            int i = 1;

            if(node is null){
                return default(T);
            }

            while(node != null){
                node = node.Next;

                if(i>k){
                    slow = slow.Next;
                }

                i++;
            }

            if(i<=k){
                return default(T);
            }

            return slow.Data;
        }
    }
}