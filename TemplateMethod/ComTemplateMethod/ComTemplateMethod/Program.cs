using System;
using ComTemplateMethod.Factory;

class Program
{
    static void Main()
    {
        var credito = PagamentoFactory.CriarPagamento("credito", 350);
        credito.RealizarCobranca();

        var debito = PagamentoFactory.CriarPagamento("debito", 200);
        debito.RealizarCobranca();

        var dinheiro = PagamentoFactory.CriarPagamento("dinheiro", 50);
        dinheiro.RealizarCobranca();
    }
}
