using Core;
using System;

namespace B.LinkedLists
{
    public class LinkedLists1
    {
        /* 
         * linked list son nodos agrupados uno tras otro sin poder saltarte solo navegando uno tra otro
         * son de las estructuras mas importantes de las estructuras de datos
         * se pueden considerar la base de otras implementaciones como los queues and stacks
         * algunos las ven similares a una cadena, comienza en el primer link, se avanza una tras otra hacia el final
         * no se puede avanzar uno tras otro sin pasar por los de entre medio
         * 
         * 
         * NODES AND NODE CHAINING
         * 
         * los nodos contienen dos partes, uno, el valor, segundo, una referencia al siguiente nodo
         * se repite una y otra vez
         * 
         */

        public void Ejecutar()
        {
            // ejemplo de nodos y su creacion con la clase nodo

            var nodo = new Node(34);

            nodo.ProximoNodo = new Node(66);

            nodo.ProximoNodo.ProximoNodo = new Node(88);

            // singly linked list
            // clase generica que contiene el valoir y la referencia al proximo nodo

            var lista = new LinkedListNode<Node>(nodo, null);

            // doubly linked list
            // es como el single pero se puede mover en reversa, teniendo una referencia al nodo anterior
            // la clase nodo (NodoD) contiene una referencia tambien al nodo anterior

            var nodo1 = new NodeD(3);
            var nodo2 = new NodeD(6);
            var nodo3 = new NodeD(9);

            nodo1.Proximo = nodo2;
            nodo2.Anterior = nodo1;
            nodo2.Proximo = nodo3;
            nodo3.Anterior = nodo2;

        }
    }
}
