using System;

public enum EstadoPedido
{
    AguardandoPagamento,
    Pago,
    Cancelado,
    Enviado
}

public class Pedido
{
    public EstadoPedido Estado { get; private set; }

    public Pedido()
    {
        Estado = EstadoPedido.AguardandoPagamento;
    }

    public void Pagar()
    {
        if (Estado == EstadoPedido.AguardandoPagamento)
        {
            Estado = EstadoPedido.Pago;
            Console.WriteLine("Pedido pago.");
        }
        else
        {
            Console.WriteLine("Não é possível pagar esse pedido.");
        }
    }

    public void Cancelar()
    {
        if (Estado == EstadoPedido.AguardandoPagamento || Estado == EstadoPedido.Pago)
        {
            Estado = EstadoPedido.Cancelado;
            Console.WriteLine("Pedido cancelado.");
        }
        else
        {
            Console.WriteLine("Não é possível cancelar esse pedido.");
        }
    }

    public void Enviar()
    {
        if (Estado == EstadoPedido.Pago)
        {
            Estado = EstadoPedido.Enviado;
            Console.WriteLine("Pedido enviado.");
        }
        else
        {
            Console.WriteLine("Não é possível enviar esse pedido.");
        }
    }
}

class Program
{
    static void Main()
    {
        Pedido pedido = new Pedido();
        pedido.Pagar();
        pedido.Enviar();
        pedido.Cancelar();
    }
}
