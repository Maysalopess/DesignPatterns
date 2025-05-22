namespace Cenario4_FreteStrategy.Fretes
{
    public class FreteExpresso : IFrete
    {
        public double Calcular(double valorPedido) => valorPedido * 0.10;
    }
}
