namespace ComTemplateMethod.Pagamentos
{
    public class PagamentoDebito : Pagamento
    {
        protected override double CalcularTaxa() => 4;
        protected override double CalcularDesconto() => Valor * 0.05;

        protected override bool ValidarPagamento()
        {
            return Valor >= 10; // Regra: Débito só pode ser feito para valores acima de R$10
        }
    }
}
