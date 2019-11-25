namespace Algorithms.LinkedListSamples
{
    public class Node<T>
    {
        private T _data;
        public T Data {
            get {
                return _data;
            }
        }
        public Node<T> Next {get; set;}
        public Node<T> Previous {get; set;}

        public Node(T data = default(T)){
            this._data = data;
        }
    }
}