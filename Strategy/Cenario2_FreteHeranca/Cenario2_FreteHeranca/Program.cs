using System;
using Cenario2_FreteHeranca.Pedidos;

class Program
{
    static void Main()
    {
        Pedido pedidoMoveis = new PedidoMoveis { ValorPedido = 200 };
        Pedido pedidoEletronicos = new PedidoEletronicos { ValorPedido = 300 };

        Console.WriteLine($"Pedido Móveis - Frete Comum: R${pedidoMoveis.CalculaFreteComum():F2}");
        Console.WriteLine($"Pedido Eletrônicos - Frete Expresso: R${pedidoEletronicos.CalculaFreteExpresso():F2}");
    }
}
