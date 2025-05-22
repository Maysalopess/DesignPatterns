using System;
using Cenario4_FreteStrategy.Fretes;
using Cenario4_FreteStrategy.Pedidos;

class Program
{
    static void Main()
    {
        Pedido pedidoMoveis = new PedidoMoveis { ValorPedido = 200 };
        Pedido pedidoEletronicos = new PedidoEletronicos { ValorPedido = 300 };

        pedidoMoveis.DefinirFrete(new FreteComum());
        pedidoEletronicos.DefinirFrete(new FreteExpresso());

        Console.WriteLine($"Pedido Móveis - Frete: R${pedidoMoveis.CalcularFrete():F2}");
        Console.WriteLine($"Pedido Eletrônicos - Frete: R${pedidoEletronicos.CalcularFrete():F2}");
    }
}
