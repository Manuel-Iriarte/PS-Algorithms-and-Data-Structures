using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedList<T> Primero { get; private set; }
        public DoublyLinkedList<T> Ultimo { get; private set; }
        public bool ObtenerPrimero(out T valor)
        {
            throw new NotImplementedException();
        }

        public bool ObtenerUltimo(out T valor)
        {
            throw new NotImplementedException();
        }

        #region ICollection Implementation

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
