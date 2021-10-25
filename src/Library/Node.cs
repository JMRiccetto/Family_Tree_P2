using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private List<Node> children = new List<Node>();

        public Persona Persona {
            get
            {
                return this.Persona;
            }
            private set
            {
                this.Persona = value;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.Persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}
