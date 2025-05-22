using System;

public abstract class EstadoPedido
{
    public abstract void Pagar(Pedido pedido);
    public abstract void Cancelar(Pedido pedido);
    public abstract void Enviar(Pedido pedido);
}

public class AguardandoPagamento : EstadoPedido
{
    public override void Pagar(Pedido pedido)
    {
        pedido.DefinirEstado(new Pago());
        Console.WriteLine("Pedido pago.");
    }

    public override void Cancelar(Pedido pedido)
    {
        pedido.DefinirEstado(new Cancelado());
        Console.WriteLine("Pedido cancelado.");
    }

    public override void Enviar(Pedido pedido) => Console.WriteLine("Não pode ser enviado antes do pagamento.");
}

public class Pago : EstadoPedido
{
    public override void Pagar(Pedido pedido) => Console.WriteLine("O pedido já está pago.");
    public override void Cancelar(Pedido pedido)
    {
        pedido.DefinirEstado(new Cancelado());
        Console.WriteLine("Pedido cancelado.");
    }
    public override void Enviar(Pedido pedido)
    {
        pedido.DefinirEstado(new Enviado());
        Console.WriteLine("Pedido enviado.");
    }
}

public class Cancelado : EstadoPedido
{
    public override void Pagar(Pedido pedido) => Console.WriteLine("Não é possível pagar um pedido cancelado.");
    public override void Cancelar(Pedido pedido) => Console.WriteLine("O pedido já está cancelado.");
    public override void Enviar(Pedido pedido) => Console.WriteLine("Não é possível enviar um pedido cancelado.");
}

public class Enviado : EstadoPedido
{
    public override void Pagar(Pedido pedido) => Console.WriteLine("O pedido já foi enviado.");
    public override void Cancelar(Pedido pedido) => Console.WriteLine("Não é possível cancelar um pedido enviado.");
    public override void Enviar(Pedido pedido) => Console.WriteLine("O pedido já foi enviado.");
}

public class Pedido
{
    private EstadoPedido _estadoAtual;
    public Pedido() => _estadoAtual = new AguardandoPagamento();
    public void DefinirEstado(EstadoPedido novoEstado) => _estadoAtual = novoEstado;
    public void Pagar() => _estadoAtual.Pagar(this);
    public void Cancelar() => _estadoAtual.Cancelar(this);
    public void Enviar() => _estadoAtual.Enviar(this);
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
