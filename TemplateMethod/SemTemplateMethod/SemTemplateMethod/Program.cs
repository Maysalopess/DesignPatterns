using System;
using SemTemplateMethod.Pagamentos;

class Program
{
    static void Main()
    {
        var credito = new PagamentoCredito { Valor = 350 };
        credito.RealizarCobranca();
    }
}
