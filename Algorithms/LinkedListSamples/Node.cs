namespace Algorithms.LinkedListSamples
{
    public class Node<T>
    {
        private T _data;
        public T data {
            get {
                return _data;
            }
        }
        public Node<T> next {get; set;}

        public Node(T data = default(T)){
            this._data = data;
        }
    }
}