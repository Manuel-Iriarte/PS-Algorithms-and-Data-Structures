namespace Core
{
    public class DoubleLinkedListNode
    {
        public DoubleLinkedListNode(int valor)
        {
            Valor = valor;
            Proximo = null;
            Anterior = null;
        }

        public DoubleLinkedListNode Proximo { get; set; }
        public DoubleLinkedListNode Anterior { get; set; }
        public int Valor { get; set; }
    }
}
