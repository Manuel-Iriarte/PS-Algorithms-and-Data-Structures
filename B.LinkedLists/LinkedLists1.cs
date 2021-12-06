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

            var lista = new ListaEnlazadaDoble<int>();


            // doubly linked list
            // es como el single pero se puede mover en reversa, teniendo una referencia al nodo anterior
            // la clase nodo (NodoD) contiene una referencia tambien al nodo anterior

            lista.Add(1);
            lista.Add(3); 
            lista.Add(5);
            lista.Add(7);

            Console.WriteLine("Listar");

            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Listar Inverso");

            foreach (int numero in lista.GetReverseEnumerator())
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Contiene valor buscado?");

            Console.WriteLine(lista.Contains(5));

            Console.WriteLine(lista.Contains(6));

            Console.WriteLine("Encuentra valor buscado?");

            Console.WriteLine(lista.Find(3).NodoAnterior.Valor);

            Console.WriteLine("Remueve un valor:");

            lista.Remove(3);

            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
