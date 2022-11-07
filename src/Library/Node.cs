using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node <T>
    {
        private int number;

        private List<Node<T>> children = new List<Node<T>>();

        public T dato{
            get;
            private set;}
        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }
        public Node(int number, T dato)
        {
            this.number = number;
            this.dato = dato;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
    }
    
}
