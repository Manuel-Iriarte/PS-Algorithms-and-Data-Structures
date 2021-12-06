using System;

namespace Core
{
    public class NodoEnlazado
    {
        public NodoEnlazado(int valor)
        {
            Valor = valor;
        }

        public NodoEnlazado NodoSiguiente { get; set; }
        public int Valor { get; set; }
    }
}
