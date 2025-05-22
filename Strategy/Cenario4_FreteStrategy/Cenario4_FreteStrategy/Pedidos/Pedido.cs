using Cenario4_FreteStrategy.Fretes;

namespace Cenario4_FreteStrategy.Pedidos
{
    public abstract class Pedido
    {
        public double ValorPedido { get; set; }
        private IFrete _frete;

        public void DefinirFrete(IFrete frete)
        {
            _frete = frete;
        }

        public double CalcularFrete()
        {
            return _frete?.Calcular(ValorPedido) ?? 0;
        }
    }
}
