namespace Core
{
    public class NodeD
    {
        public NodeD(int valor)
        {
            Valor = valor;
            Proximo = null;
            Anterior = null;
        }

        public NodeD Proximo { get; set; }
        public NodeD Anterior { get; set; }
        public int Valor { get; set; }
    }
}
