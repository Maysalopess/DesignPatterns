using AbstractFactorySolucao.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class BBJuros : IJuros
{
    public double Calcular(double valor) => valor * 0.1;
}

