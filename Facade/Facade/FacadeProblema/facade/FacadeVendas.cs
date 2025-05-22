using FacadeProblema.cadastros;
using FacadeProblema.vendas;

namespace FacadeProblema.facade;

public class FacadeVendas
{
    private Pedido pedido;
    private Pagamento pagamento;
    private EmailPedido email;

    public FacadeVendas(Consumidor consumidor)
    {
        this.pedido = new Pedido();
        this.pedido.consumidor = consumidor;
        this.email = new EmailPedido(pedido);
    }

    public void addProduto(Produto produto)
    {
        this.pedido.addProduto(produto);
    }

    public void pedidoCredito()
    {
        this.pagamento = new PagamentoCredito(this.pedido);
        if (this.pagamento.realizarPagamento())
        {
            this.email.enviarEmail("Pagamento realizado com sucesso (crédito)");
        }
        else
        {
            this.email.enviarEmail("Falha no pagamento do pedido");
        }
    }
    
    public void pedidoBoleto()
    {
        this.pagamento = new PagamentoBoleto(this.pedido);
        if (this.pagamento.realizarPagamento())
        {
            this.email.enviarEmail("Pagamento realizado com sucesso (Boleto)");
        }
        else
        {
            this.email.enviarEmail("Falha no pagamento do pedido");
        }
    }
    
    
}