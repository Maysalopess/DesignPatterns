namespace ComTemplateMethod.Pagamentos
{
    public class PagamentoDinheiro : Pagamento
    {
        protected override double CalcularTaxa() => 0;
        protected override double CalcularDesconto() => Valor * 0.10;
    }
}
