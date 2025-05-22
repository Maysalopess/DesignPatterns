namespace Decorator.Pizza;

public class BordaRequeijao : AcrecimoDecorator
{

    private double valorBorda = 8.5;

    public BordaRequeijao(Pizza pizza)
    {
        this.pizza = pizza;
    }
    
    public override string getDescricao()
    {
        return this.pizza.getDescricao() + " Borda de requeijão";
    }

    public override double getPreco()
    {
        return this.pizza.getPreco() + valorBorda;
    }
}