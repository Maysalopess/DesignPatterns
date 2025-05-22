namespace Cenario3_FreteRestrito.Pedidos
{
    public class PedidoEletronicos : Pedido
    {
        public override double CalculaFreteComum() => ValorPedido * 0.05;
        public override double CalculaFreteExpresso() => ValorPedido * 0.10;
    }
}
