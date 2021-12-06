namespace Core
{
    public class ListaEnlazada<TNodo>
    {
        public ListaEnlazada(TNodo valor)
        {
            Valor = valor;
        }
        public ListaEnlazada<TNodo> SiguienteNodo { get; set; }
        public TNodo Valor { get; set; }
    }
}
