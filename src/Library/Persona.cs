using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Persona 
    {
        public string Nombre;
        public int Edad;
        public Persona(string nombre, int edad){
            this.Nombre = nombre;
            this.Edad = edad;
        }
        int getEdad()
        {
            return this.Edad;    
        }
    }

}