using System;
using Cenario3_FreteRestrito.Pedidos;

class Program
{
    static void Main()
    {
        Pedido pedidoMoveis = new PedidoMoveis { ValorPedido = 200 };
        Pedido pedidoEletronicos = new PedidoEletronicos { ValorPedido = 300 };

        Console.WriteLine($"Pedido Móveis - Frete Comum: R${pedidoMoveis.CalculaFreteComum():F2}");

        try
        {
            Console.WriteLine($"Pedido Móveis - Frete Expresso: R${pedidoMoveis.CalculaFreteExpresso():F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine($"Pedido Eletrônicos - Frete Expresso: R${pedidoEletronicos.CalculaFreteExpresso():F2}");
    }
}
