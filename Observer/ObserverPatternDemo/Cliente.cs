using System;

public class Cliente : IObserver
{
    private string _nome;

    public Cliente(string nome)
    {
        _nome = nome;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Cliente {_nome} recebeu a notificação: {message}");
    }
}
