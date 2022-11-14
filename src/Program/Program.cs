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
            Persona jorge = new Persona("jorge",1);
            Persona juan = new Persona("juan",1);
            Persona julian = new Persona("julian",1);
            Persona julieta= new Persona("julieta",1);
            Persona jimena = new Persona("jimena",1);
            Persona jose = new Persona("jose",1);
            Persona juana = new Persona("juana",1);
            Persona jesus = new Persona("jesus",1);

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
            recorreArbol(juan2,visitnode);
            recorreArbol(julian3,visitnode);
            recorreArbol(juana7,visitnode);
            Console.WriteLine(visitnode.edadesTotales);
            
        }

        public static void recorreArbol(Node<Persona> parent,VisitorPersona visitorNode){
            parent.Accept(visitorNode);
            foreach (var child in parent.Children)
            {
                recorreArbol(child,visitorNode);
            }
        }
    }
}
