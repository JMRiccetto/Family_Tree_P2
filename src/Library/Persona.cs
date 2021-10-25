using System.Collections.Generic;

namespace Library
{
    public class Persona
    {
        public int edad;
        private string nombre;
        private List<Node> children = new List<Node>();
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}