namespace Core
{
    public class NodoEnlazadoDoble<T>
    {
        public NodoEnlazadoDoble(T valor)
        {
            Valor = valor;
        }

        public T Valor { get; set; }

        public NodoEnlazadoDoble<T> NodoSiguiente { get; set; }
        public NodoEnlazadoDoble<T> NodoAnterior { get; set; }
        
    }
}
