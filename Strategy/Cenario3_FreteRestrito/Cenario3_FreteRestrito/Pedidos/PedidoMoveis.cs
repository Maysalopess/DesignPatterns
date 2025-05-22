using System;

namespace Cenario3_FreteRestrito.Pedidos
{
    public class PedidoMoveis : Pedido
    {
        public override double CalculaFreteComum() => ValorPedido * 0.05;

        public override double CalculaFreteExpresso()
        {
            throw new InvalidOperationException("Frete Expresso não disponível para Móveis.");
        }
    }
}
