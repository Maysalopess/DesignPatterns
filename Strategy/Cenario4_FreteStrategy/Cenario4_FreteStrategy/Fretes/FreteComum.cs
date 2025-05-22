namespace Cenario4_FreteStrategy.Fretes
{
    public class FreteComum : IFrete
    {
        public double Calcular(double valorPedido) => valorPedido * 0.05;
    }
}
