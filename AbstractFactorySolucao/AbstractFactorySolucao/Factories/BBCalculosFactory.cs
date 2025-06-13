using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactorySolucao.Calculo;
using AbstractFactorySolucao.Factories;

public class BBCalculosFactory : ICalculosFactory
{
    public IJuros CriarJuros() => new BBJuros();
    public IMulta CriarMulta() => new BBMulta();
    public IDesconto CriarDesconto() => new BBDesconto();
}

