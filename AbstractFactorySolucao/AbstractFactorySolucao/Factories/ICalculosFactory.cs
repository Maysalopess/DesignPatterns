using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactorySolucao.Calculo;

namespace AbstractFactorySolucao.Factories
{
    public interface ICalculosFactory
    {
        IJuros CriarJuros();
        IMulta CriarMulta();
        IDesconto CriarDesconto();
    }
}

