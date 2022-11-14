using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deberia Funcionar pero hay un error en Visitor que no tiene sentindo. trate de todo pero nada funca 
            
            // ocho personas
            Persona jorge = new Persona("jorge",10);
            Persona juan = new Persona("juan",1);
            Persona julian = new Persona("julian",1);
            Persona julieta= new Persona("julieta",1);
            Persona jimena = new Persona("jimena",1);
            Persona jose = new Persona("jose",1);
            Persona juana = new Persona("juana",1);
            Persona jesus = new Persona("jesus",20);

            // ocho nodos con las personas
            Node<Persona> jorge1 = new Node<Persona>(jorge);
            Node<Persona> juan2 = new Node<Persona>(juan);
            Node<Persona> julian3 = new Node<Persona>(julian);
            Node<Persona> julieta4 = new Node<Persona>(julieta);
            Node<Persona> jimena5 = new Node<Persona>(jimena);
            Node<Persona> jose6 = new Node<Persona>(jose);
            Node<Persona> juana7 = new Node<Persona>(juana);
            Node<Persona> jesus8 = new Node<Persona>(jesus);

            //arbol
            jorge1.AddChildren(juan2);
            jorge1.AddChildren(julian3);

            juan2.AddChildren(julieta4);
            juan2.AddChildren(jimena5);

            julian3.AddChildren(jose6);
            julian3.AddChildren(juana7);
            juana7.AddChildren(jesus8);
            
            // visitar el árbol aquí
            Console.WriteLine(juana7.Dato);
            VisitorPersona visitnode = new VisitorPersona();
            recorreArbol(jorge1,visitnode);

            Console.WriteLine("Edades Totales = " + visitnode.edadesTotales);
            //hijo mas grande 
            VisitorHijoMasGrande visitHijosMasGrande = new VisitorHijoMasGrande();
            recorreArbol(jorge1,visitHijosMasGrande);
            recorreArbol(juan2,visitHijosMasGrande);
            recorreArbol(julian3,visitHijosMasGrande);
            recorreArbol(juana7,visitHijosMasGrande);
            Console.WriteLine("Hijo Mayor = " + visitHijosMasGrande.HijoMasViejo);
            //nombre mas largo 
            VisitorNombreMasLargo visitorNombreMasLargo = new VisitorNombreMasLargo();
            recorreArbol(jorge1,visitorNombreMasLargo);
            recorreArbol(juan2,visitorNombreMasLargo);
            recorreArbol(julian3,visitorNombreMasLargo);
            recorreArbol(juana7,visitorNombreMasLargo);
            Console.WriteLine("Nombre más Largo = " + visitorNombreMasLargo.largoNombre);
        }

        public static void recorreArbol(Node<Persona> parent,IVisitor<Persona> visitorNode){
            parent.Accept(visitorNode);
            foreach (var child in parent.Children)
            {
                recorreArbol(child,visitorNode);
            }
        }
    }
}
