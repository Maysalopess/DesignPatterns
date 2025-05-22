using System;

namespace ComTemplateMethod.Pagamentos
{
    public class GatewayPagamento
    {
        private static readonly Random random = new Random();

        public bool Cobrar(double valor)
        {
            return random.Next(0, 2) == 1; // Retorna true ou false aleatoriamente
        }
    }
}
