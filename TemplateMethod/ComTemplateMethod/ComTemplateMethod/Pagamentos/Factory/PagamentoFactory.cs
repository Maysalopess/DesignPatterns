using System;
using ComTemplateMethod.Pagamentos;

namespace ComTemplateMethod.Factory
{
    public static class PagamentoFactory
    {
        public static Pagamento CriarPagamento(string tipo, double valor)
        {
            Pagamento pagamento = tipo.ToLower() switch
            {
                "credito" => new PagamentoCredito(),
                "debito" => new PagamentoDebito(),
                "dinheiro" => new PagamentoDinheiro(),
                _ => throw new ArgumentException("Tipo de pagamento inválido!")
            };

            pagamento.Valor = valor;
            return pagamento;
        }
    }
}
