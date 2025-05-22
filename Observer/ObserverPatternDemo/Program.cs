using System;

class Program
{
    static void Main(string[] args)
    {
        Newsletter newsletter = new Newsletter();

        Cliente cliente1 = new Cliente("Kaléo");
        Cliente cliente2 = new Cliente("Maysa");
        Fornecedor fornecedor1 = new Fornecedor("Empresa X");

        newsletter.Subscribe(cliente1);
        newsletter.Subscribe(cliente2);
        newsletter.Subscribe(fornecedor1);

        Console.WriteLine("Enviando primeira notificação...");
        newsletter.NotifyObservers("Novo produto disponível!");

        Console.WriteLine("\nRemovendo Kaléo da lista de assinantes...\n");
        newsletter.Unsubscribe(cliente1);

        Console.WriteLine("Enviando segunda notificação...");
        newsletter.NotifyObservers("Promoção especial para assinantes!");

        Console.ReadLine();
    }
}
