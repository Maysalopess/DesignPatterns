using AbstractFactorySolucao.Calculo;
using AbstractFactorySolucao.Factories;
using System;

namespace AbstractFactorySolucao.Model
{
    public class Boleto
    {
        private readonly IJuros _juros;
        private readonly IMulta _multa;
        private readonly IDesconto _desconto;

        public Boleto(ICalculosFactory factory)
        {
            _juros = factory.CriarJuros();
            _multa = factory.CriarMulta();
            _desconto = factory.CriarDesconto();
        }

        public void ExibirResumo(double valorBase)
        {
            Console.WriteLine($"Valor base: R$ {valorBase}");
            Console.WriteLine($"Juros: R$ {_juros.Calcular(valorBase)}");
            Console.WriteLine($"Multa: R$ {_multa.Calcular(valorBase)}");
            Console.WriteLine($"Desconto: R$ {_desconto.Calcular(valorBase)}");
        }
    }
}
