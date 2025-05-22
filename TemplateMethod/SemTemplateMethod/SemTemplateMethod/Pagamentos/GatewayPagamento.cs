using System;

namespace SemTemplateMethod.Pagamentos
{
    public class GatewayPagamento
    {
        private static readonly Random random = new Random();

        public bool Cobrar(double valor)
        {
            return random.Next(0, 2) == 1; // Simula aprovação ou recusa aleatoriamente
        }
    }
}
