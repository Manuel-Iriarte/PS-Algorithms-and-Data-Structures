using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class ListaEnlazadaDoble<T> : ICollection<T>
    {
        public NodoEnlazadoDoble<T> PrimerNodo { get; private set; }
        public NodoEnlazadoDoble<T> UltimoNodo { get; private set; }

        #region Agregar
        public void Add(T item)
        {
            AgregarAlPrincipio(item);
        }
        public void AgregarAlPrincipio(T valor)
        {
            AgregarAlPrincipio(new NodoEnlazadoDoble<T>(valor));
        }

        public void AgregarAlFinal(T valor)
        {

        }

        public void AgregarAlPrincipio(NodoEnlazadoDoble<T> nodo)
        {
            NodoEnlazadoDoble<T> temp = PrimerNodo;
            PrimerNodo = nodo;
            PrimerNodo.NodoSiguiente = temp;

            if (Count == 0)
                UltimoNodo = PrimerNodo;
            else
                temp.NodoAnterior = PrimerNodo;

            Count++;
        }

        public void AgregarAlFinal(NodoEnlazadoDoble<T> nodo)
        {
            if (Count == 0)
            {
                PrimerNodo = nodo;
            }
            else
            {
                UltimoNodo.NodoSiguiente = nodo;
                nodo.NodoAnterior = UltimoNodo;
            }

            UltimoNodo = nodo;
            Count++;
        }

        #endregion

        public bool ObtenerPrimero(out T valor)
        {
            throw new NotImplementedException();
        }

        public bool ObtenerUltimo(out T valor)
        {
            throw new NotImplementedException();
        }

        #region ICollection Implementation

        public int Count { get; set; }

        public bool IsReadOnly => throw new System.NotImplementedException();

        #region No Implementado

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public NodoEnlazadoDoble<T> Find(T item)
        {
            NodoEnlazadoDoble<T> current = PrimerNodo;
            while (current != null)
            {
                if (current.Valor.Equals(item))
                {
                    return current;
                }

                current = current.NodoSiguiente;
            }

            return null;
        }

        public bool Contains(T item)
        {
            return Find(item) != null;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Listar

        public IEnumerator<T> GetEnumerator()
        {
            NodoEnlazadoDoble<T> current = PrimerNodo;
            while (current != null)
            {
                yield return current.Valor;
                current = current.NodoSiguiente;
            }
        }

        public IEnumerable<T> GetReverseEnumerator()
        {
            NodoEnlazadoDoble<T> current = UltimoNodo;
            while (current != null)
            {
                yield return current.Valor;
                current = current.NodoAnterior;
            }
        }

        #endregion

        public bool Remove(T item)
        {
            NodoEnlazadoDoble<T> found = Find(item);
            if (found == null)
            {
                return false;
            }

            NodoEnlazadoDoble<T> previous = found.NodoAnterior;
            NodoEnlazadoDoble<T> next = found.NodoSiguiente;

            if (previous == null)
            {
                // we're removing the head node
                PrimerNodo = next;
                if (PrimerNodo != null)
                {
                    PrimerNodo.NodoSiguiente = null;
                }
            }
            else
            {
                previous.NodoSiguiente = next;
            }

            if (next == null)
            {
                // we're removing the tail
                UltimoNodo = previous;
                if (UltimoNodo != null)
                {
                    UltimoNodo.NodoSiguiente = null;
                }
            }
            else
            {
                next.NodoAnterior = previous;
            }

            Count--;

            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
