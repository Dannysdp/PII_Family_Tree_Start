using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Library
{
    public class VisitorPersona : IVisitor<Persona>
    {
        public int edadesTotales{get;set;}
        public void VisitNode(Node<Persona> node)
        {
            this.edadesTotales += node.Dato.Edad;
        }
    }
}