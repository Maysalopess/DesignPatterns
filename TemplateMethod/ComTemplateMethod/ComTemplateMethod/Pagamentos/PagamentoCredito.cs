namespace ComTemplateMethod.Pagamentos
{
    public class PagamentoCredito : Pagamento
    {
        protected override double CalcularTaxa() => Valor * 0.05;
        protected override double CalcularDesconto() => Valor > 300 ? Valor * 0.02 : 0;
    }
}
