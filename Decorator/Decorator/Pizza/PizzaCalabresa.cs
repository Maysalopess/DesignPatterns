namespace Decorator.Pizza;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa()
    {
        this.descricao = "Calabresa";
        this.preco = 25;
    }
    
    public override string getDescricao()
    {
        return this.descricao;
    }

    public override double getPreco()
    {
        return this.preco;
    }
}