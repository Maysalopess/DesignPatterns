using System;

public class Fornecedor : IObserver
{
    private string _nome;

    public Fornecedor(string nome)
    {
        _nome = nome;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Fornecedor {_nome} recebeu a notificação: {message}");
    }
}
