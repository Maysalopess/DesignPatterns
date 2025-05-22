namespace Cenario1_FreteSimples.Pedidos
{
    public class Pedido
    {
        public double ValorPedido { get; set; }

        public double CalculaFreteComum()
        {
            return ValorPedido * 0.10;
        }

        public double CalculaFreteExpresso()
        {
            return ValorPedido * 0.20;
        }
    }
}
