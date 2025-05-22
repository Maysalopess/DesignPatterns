namespace Decorator.Pizza;

internal class MassaIntegral : AcrecimoDecorator
{

    private double valorMassaIntegral = 5;

    public MassaIntegral(Pizza pizza)
    {
        this.pizza = pizza;
    }
    
    public override string getDescricao()
    {
        return this.pizza.getDescricao() + " Massa Integral";
    }

    public override double getPreco()
    {
        return this.pizza.getPreco() + valorMassaIntegral;
    }
}