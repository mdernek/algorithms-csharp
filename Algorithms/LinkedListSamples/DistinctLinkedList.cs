//https://www.geeksforgeeks.org/remove-duplicates-from-an-unsorted-linked-list/?source=post_page---------------------------
using System.Collections.Generic;

namespace Algorithms.LinkedListSamples
{
    public interface IDistinctLinkedList<T>
    {
        void MakeDistinct();
    }

    public partial class LinkedList<T>: IDistinctLinkedList<T>
    {
        public void MakeDistinct(){
            Node<T> node = this.GetNode();
            Node<T> distinctNode = null;
            HashSet<T> dataSet = new HashSet<T>();

            while(node != null){
                if(!dataSet.Contains(node.Data)){
                    distinctNode = node;
                    dataSet.Add(node.Data);
                }
                else {
                    distinctNode.Next = node.Next;
                }

                node = node.Next;
            }
        }
    }
}