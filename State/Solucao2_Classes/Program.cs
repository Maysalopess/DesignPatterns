using System;

public interface IPedidoEstado
{
    void Pagar(Pedido pedido);
    void Cancelar(Pedido pedido);
    void Enviar(Pedido pedido);
}

public class AguardandoPagamento : IPedidoEstado
{
    public void Pagar(Pedido pedido)
    {
        pedido.Estado = new Pago();
        Console.WriteLine("Pedido pago.");
    }

    public void Cancelar(Pedido pedido)
    {
        pedido.Estado = new Cancelado();
        Console.WriteLine("Pedido cancelado.");
    }

    public void Enviar(Pedido pedido)
    {
        Console.WriteLine("Não é possível enviar antes do pagamento.");
    }
}

public class Pago : IPedidoEstado
{
    public void Pagar(Pedido pedido) => Console.WriteLine("O pedido já está pago.");
    public void Cancelar(Pedido pedido)
    {
        pedido.Estado = new Cancelado();
        Console.WriteLine("Pedido cancelado.");
    }
    public void Enviar(Pedido pedido)
    {
        pedido.Estado = new Enviado();
        Console.WriteLine("Pedido enviado.");
    }
}

public class Cancelado : IPedidoEstado
{
    public void Pagar(Pedido pedido) => Console.WriteLine("Não é possível pagar um pedido cancelado.");
    public void Cancelar(Pedido pedido) => Console.WriteLine("O pedido já está cancelado.");
    public void Enviar(Pedido pedido) => Console.WriteLine("Não é possível enviar um pedido cancelado.");
}

public class Enviado : IPedidoEstado
{
    public void Pagar(Pedido pedido) => Console.WriteLine("O pedido já foi enviado.");
    public void Cancelar(Pedido pedido) => Console.WriteLine("Não é possível cancelar um pedido enviado.");
    public void Enviar(Pedido pedido) => Console.WriteLine("O pedido já foi enviado.");
}

public class Pedido
{
    public IPedidoEstado Estado { get; set; }
    public Pedido() => Estado = new AguardandoPagamento();

    public void Pagar() => Estado.Pagar(this);
    public void Cancelar() => Estado.Cancelar(this);
    public void Enviar() => Estado.Enviar(this);
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
