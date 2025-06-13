
using AbstractFactorySolucao.Calculo;
using AbstractFactorySolucao.Factories;

public class CaixaCalculosFactory : ICalculosFactory
{
    public IJuros CriarJuros() => new CaixaJuros();
    public IMulta CriarMulta() => new CaixaMulta();
    public IDesconto CriarDesconto() => new CaixaDesconto();
}

