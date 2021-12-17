using Core;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //var lista = new ListaEnlazadaDoble<int>();



            var listaOriginal = new List<int>();

            listaOriginal.Add(1);
            listaOriginal.Add(2);
            listaOriginal.Add(1);
            listaOriginal.Add(4);
            listaOriginal.Add(5);
            listaOriginal.Add(4);

            var result = 0;
            var listas = new List<List<int>>();
            int count = 0;
            int teamsNumber = listaOriginal.Count / 3;
            var maxVal = listaOriginal.Max(n => n);
            var minVval = maxVal - 2;

            for (int i = 0; i < 3; i++)
            {
                var lista = new List<int>();

                foreach (int sk in listaOriginal)
                {
                    if (count != 3 && sk >= minVval && sk <= maxVal)
                    {
                        lista.Add(sk);
                        count++;
                    }
                }
                listas.Add(lista);
                if (i < teamsNumber)
                {
                    maxVal = listaOriginal.Where(n => n < minVval).Max(n => n);
                    minVval = maxVal - 2;
                }
            }

            foreach (var l in listas)
            {
                Console.WriteLine(l.Count);
                foreach (int u in l)
                {
                    Console.WriteLine(u);
                }
            }



            //var listas = new List<List<int>>();


            //foreach(int skill in listaOriginal)
            //{
            //    if(1 <= 9)
            //    {

            //    }
            //}

            Console.WriteLine();
            // doubly linked list
            // es como el single pero se puede mover en reversa, teniendo una referencia al nodo anterior
            // la clase nodo (NodoD) contiene una referencia tambien al nodo anterior

            //lista.Add(1);
            //lista.Add(3); 
            //lista.Add(5);
            //lista.Add(7);

            //Console.WriteLine("Listar");

            //foreach (int numero in lista)
            //{
            //    Console.WriteLine(numero);
            //}

            //Console.WriteLine("Listar Inverso");

            //foreach (int numero in lista.GetReverseEnumerator())
            //{
            //    Console.WriteLine(numero);
            //}

            //Console.WriteLine("Contiene valor buscado?");

            //Console.WriteLine(lista.Contains(5));

            //Console.WriteLine(lista.Contains(6));

            //Console.WriteLine("Encuentra valor buscado?");

            //Console.WriteLine(lista.Find(3).NodoAnterior.Valor);

            //Console.WriteLine("Remueve un valor:");

            //lista.Remove(3);

            //foreach (int numero in lista)
            //{
            //    Console.WriteLine(numero);
            //}
        }
    }
}
