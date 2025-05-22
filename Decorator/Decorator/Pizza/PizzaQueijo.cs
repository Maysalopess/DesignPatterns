namespace Decorator.Pizza;

public class PizzaQueijo : Pizza
{
    public PizzaQueijo()
    {
        this.descricao = "Queijo";
        this.preco = 22;
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