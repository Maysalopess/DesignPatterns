using AbstractFactorySolucao.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BBDesconto : IDesconto
{
    public double Calcular(double valor) => valor * 0.02;
}

