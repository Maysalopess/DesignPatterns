namespace Decorator.Pizza;

public abstract class AcrecimoDecorator: Pizza
{
    protected Pizza pizza;

    public override abstract string getDescricao();
    public override abstract double getPreco();

}