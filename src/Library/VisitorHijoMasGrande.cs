using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Library
{
    public class VisitorHijoMasGrande : IVisitor<Persona>
    {

        public int HijoMasViejo = 0;

        public void VisitNode(Node<Persona> node)
        {
        if(node.Dato.Edad > HijoMasViejo)
        {
            HijoMasViejo = node.Dato.Edad;
        }
    }
    }
}