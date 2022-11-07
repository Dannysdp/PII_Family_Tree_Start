using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Library
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public List<Node> hijos = new List<Node>();
    }
}