using System;

namespace SemTemplateMethod.Pagamentos
{
    public class PagamentoDebito
    {
        public double Valor { get; set; }
        private GatewayPagamento gateway = new GatewayPagamento();

        public double CalcularTaxa() => 4;
        public double CalcularDesconto() => Valor * 0.05;

        public void RealizarCobranca()
        {
            double valorFinal = Valor + CalcularTaxa() - CalcularDesconto();
            if (gateway.Cobrar(valorFinal))
                Console.WriteLine($"Pagamento no débito aprovado: R${valorFinal:F2}");
            else
                Console.WriteLine("Pagamento no débito recusado.");
        }
    }
}
