using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class VisitorPersona<Persona> : IVisitor<Persona>
    {
        public int edad{get;set;}
        public void VisitNode(Node<Persona> node)
        {
            //Console.WriteLine(node.Dato.GetType()); probando si es del mismo tipo y es ¯\_(ツ)_/¯
            this.edad += node.Dato.Edad;
        }
    }
}