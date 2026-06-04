using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGulosos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pelo que foi testado o algoritmo guloso realiza escolhas locais (maior item que cabe no momento),
            // não testando todas as combinações possíveis. Por isso, nesse caso não encontrou a melhor soluçao global que seria os 100L
            Questao1.Resolver();

            // solução foi feita calculando a prioriade = (valor/tempo). Apesar de eficiente,
            // nao garante otimizaçao global, pois nao explora todas as combinaçoes possiveis de locais.
            Questao2.Resolver();

            // testando ele garante a melhor escolha local a cada passo (maior cobertura de estados não atendidos).
            // mas isso nao implica no melhor global, pois decisoes locais podem impedir combinações melhores no final.
            Questao3.Resolver();
        }
    }
}
