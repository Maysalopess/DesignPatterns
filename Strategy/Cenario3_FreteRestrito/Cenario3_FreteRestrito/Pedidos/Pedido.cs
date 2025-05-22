namespace Cenario3_FreteRestrito.Pedidos
{
    public abstract class Pedido
    {
        public double ValorPedido { get; set; }

        public abstract double CalculaFreteComum();
        public abstract double CalculaFreteExpresso();
    }
}
