using AbstractFactorySolucao.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CaixaMulta : IMulta
{
    public double Calcular(double valor) => valor * 0.03;
}

