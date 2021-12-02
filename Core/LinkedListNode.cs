namespace Core
{
    public class LinkedListNode<TNode>
    {
        public LinkedListNode(TNode valor, LinkedListNode<TNode> proximo = null)
        {
            Valor = valor;
            Proximo = proximo;
        }

        public LinkedListNode<TNode> Proximo { get; set; }
        public TNode Valor { get; set; }
    }
}
