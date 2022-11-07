using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node
    {
        private int number;

        private List<Node> children = new List<Node>();

        private Persona persona{get;set;}
        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }
        public Node(int number,Persona persona)
        {
            this.number = number;
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
    
}
