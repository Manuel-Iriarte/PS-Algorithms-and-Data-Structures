namespace Core
{
    public class LinkedList<TNode>
    {
        public LinkedList(TNode valor, LinkedList<TNode> proximo = null)
        {
            Valor = valor;
            Proximo = proximo;
        }

        public LinkedList<TNode> Proximo { get; set; }
        public TNode Valor { get; set; }
    }
}
