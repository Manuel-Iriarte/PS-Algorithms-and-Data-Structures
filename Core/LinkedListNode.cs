using System;

namespace Core
{
    public class LinkedListNode
    {
        public LinkedListNode(int valor)
        {
            Valor = valor;
            ProximoNodo = null;
        }

        public LinkedListNode ProximoNodo { get; set; }
        public int Valor { get; set; }
    }
}
