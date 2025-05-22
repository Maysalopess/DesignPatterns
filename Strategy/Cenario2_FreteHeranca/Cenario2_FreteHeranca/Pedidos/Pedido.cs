namespace Cenario2_FreteHeranca.Pedidos
{
    public abstract class Pedido
    {
        public double ValorPedido { get; set; }

        public double CalculaFreteComum() => ValorPedido * 0.05;
        public double CalculaFreteExpresso() => ValorPedido * 0.10;
    }
}
