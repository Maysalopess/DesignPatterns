namespace Decorator.Pizza;

public class PizzaFrango : Pizza
{
    public PizzaFrango()
    {
        this.descricao = "Frango";
        this.preco = 19;
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