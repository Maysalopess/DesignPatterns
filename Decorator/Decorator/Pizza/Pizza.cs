namespace Decorator.Pizza;

public abstract class Pizza
{
    protected string descricao { get; set; }
    protected double preco { get; set; }

    public abstract string getDescricao();
    public abstract double getPreco();
}