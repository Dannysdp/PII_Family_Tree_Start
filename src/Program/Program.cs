using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Node jorge1 = new Node(1,jorge);
            Node juan2 = new Node(2,juan);
            Node julian3 = new Node(3,julian);
            Node julieta4 = new Node(4,julieta);
            Node jimena5 = new Node(5,jimena);
            Node jose6 = new Node(6,jose);
            Node juana7 = new Node(7,juana);
            Node jesus8 = new Node(8,jesus);
            //arbol
            jorge1.AddChildren(juan2);
            jorge1.AddChildren(julian3);

            juan2.AddChildren(julieta4);
            juan2.AddChildren(jimena5);

            julian3.AddChildren(jose6);
            julian3.AddChildren(juana7);
            juana7.AddChildren(jesus8);
            
            // visitar el árbol aquí
            Console.WriteLine(juana7);
        }
    }
}
