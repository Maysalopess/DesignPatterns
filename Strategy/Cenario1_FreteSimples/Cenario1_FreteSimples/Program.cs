using System;
using Cenario1_FreteSimples.Pedidos;

class Program
{
    static void Main()
    {
        Pedido pedido = new Pedido { ValorPedido = 100 };

        Console.WriteLine($"Frete Comum: R${pedido.CalculaFreteComum():F2}");
        Console.WriteLine($"Frete Expresso: R${pedido.CalculaFreteExpresso():F2}");
    }
}
