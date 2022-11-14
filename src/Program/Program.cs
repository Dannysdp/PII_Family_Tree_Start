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
            Persona jorge = new Persona("jorge",50);
            Persona juan = new Persona("juan",20);
            Persona julian = new Persona("julian",3);
            Persona julieta= new Persona("julieta",56);
            Persona jimena = new Persona("jimena",4);
            Persona jose = new Persona("jose",786876);
            Persona juana = new Persona("juana",5);
            Persona jesus = new Persona("jesus",2022);

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
            VisitorPersona<Persona> visitnode = new VisitorPersona<Persona>();
            jorge1.Accept(visitnode);
            juan2.Accept(visitnode);
            julian3.Accept(visitnode);
            juana7.Accept(visitnode);
            Console.WriteLine(visitnode.edad);
            
        }
        public void recorreArbol(Node<Persona> parent,VisitorPersona<Persona> visitorNode){
            parent.Accept(visitorNode);
            foreach (var chlid in parent.Children)
            {
                recorreArbol(chlid,visitorNode);
            }
        }
    }
}
