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

        }
    }
}
