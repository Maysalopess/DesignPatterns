using AbstractFactorySolucao.Factories;
using AbstractFactorySolucao.Model;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boleto do Banco do Brasil:");
        var bbFactory = new BBCalculosFactory();
        var boletoBB = new Boleto(bbFactory);
        boletoBB.ExibirResumo(1000);

        Console.WriteLine("\nBoleto da Caixa:");
        var caixaFactory = new CaixaCalculosFactory();
        var boletoCaixa = new Boleto(caixaFactory);
        boletoCaixa.ExibirResumo(1000);
    }
}
