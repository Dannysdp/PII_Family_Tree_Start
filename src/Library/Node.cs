using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node <T> : IComponent<T>
    {
        private List<Node<T>> children = new List<Node<T>>();

        public T Dato{
            get;
            private set;}

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T dato)
        {
            this.Dato = dato;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public void Accept(IVisitor<T> visitor)
        {
            visitor.VisitNode(this);
        }
        
    }
    
}
