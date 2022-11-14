using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Library
{
    public class VisitorNombreMasLargo : IVisitor<Persona>
    {
        public int largoNombre = 0;
        public void VisitNode(Node<Persona> node)
        {
            if(node.Dato.Nombre.Length > largoNombre){
                largoNombre = node.Dato.Nombre.Length;
            }
        }
    }
}