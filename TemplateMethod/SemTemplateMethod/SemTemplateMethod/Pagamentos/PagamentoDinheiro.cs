using System;

namespace SemTemplateMethod.Pagamentos
{
    public class PagamentoDinheiro
    {
        public double Valor { get; set; }
        private GatewayPagamento gateway = new GatewayPagamento();

        public double CalcularTaxa() => 0;
        public double CalcularDesconto() => Valor * 0.10;

        public void RealizarCobranca()
        {
            double valorFinal = Valor - CalcularDesconto();
            if (gateway.Cobrar(valorFinal))
                Console.WriteLine($"Pagamento em dinheiro aprovado: R${valorFinal:F2}");
            else
                Console.WriteLine("Pagamento em dinheiro recusado.");
        }
    }
}
