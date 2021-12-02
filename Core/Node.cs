using System;

namespace Core
{
    public class Node
    {
        public Node(int valor)
        {
            Valor = valor;
            ProximoNodo = null;
        }

        public Node ProximoNodo { get; set; }
        public int Valor { get; set; }
    }
}
