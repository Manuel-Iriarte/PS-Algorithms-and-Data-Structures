namespace Core
{
    public class DoublyLinkedListNode<TNode>
    {
        public DoublyLinkedListNode(TNode valor, LinkedListNode<TNode> proximo = null, LinkedListNode<TNode> anterior = null)
        {
            Valor = valor;
            Proximo = proximo;
            Anterior = anterior;
        }

        public LinkedListNode<TNode> Proximo { get; set; }
        public LinkedListNode<TNode> Anterior { get; set; }
        public TNode Valor { get; set; }
    }
}
