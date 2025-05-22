using System;

namespace ComTemplateMethod.Pagamentos
{
    public abstract class Pagamento
    {
        public double Valor { get; set; }
        protected readonly GatewayPagamento gateway;

        public Pagamento()
        {
            gateway = new GatewayPagamento();
        }

        // Template Method - Define o fluxo de pagamento
        public void RealizarCobranca()
        {
            if (!ValidarPagamento())
            {
                Console.WriteLine($"[{GetType().Name}] Falha na validação do pagamento.");
                return;
            }

            double valorFinal = Valor + CalcularTaxa() - CalcularDesconto();
            string resultado = gateway.Cobrar(valorFinal) ? "APROVADO" : "RECUSADO";
            Console.WriteLine($"[{GetType().Name}] Valor: R${valorFinal:F2} - Status: {resultado}");
        }

        protected virtual bool ValidarPagamento() => true; // Hook opcional  
        protected abstract double CalcularTaxa();
        protected abstract double CalcularDesconto();
    }
}
