using System;

namespace SemTemplateMethod.Pagamentos
{
    public class PagamentoCredito
    {
        public double Valor { get; set; }
        private readonly GatewayPagamento gateway;

        public PagamentoCredito()
        {
            gateway = new GatewayPagamento();
        }

        public double CalcularTaxa() => Valor * 0.05;
        public double CalcularDesconto() => Valor > 300 ? Valor * 0.02 : 0;

        public void RealizarCobranca()
        {
            double valorFinal = Valor + CalcularTaxa() - CalcularDesconto();
            string resultado = gateway.Cobrar(valorFinal) ? "APROVADO" : "RECUSADO";
            Console.WriteLine($"[CREDITO] Valor: R${valorFinal:F2} - Status: {resultado}");
        }
    }
}
