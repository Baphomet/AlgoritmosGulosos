using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosGulosos
{
    public static class Questao3
    {
        public static void Resolver()
        {
            var estadosNecessarios = new HashSet<string>
            {
                "MT", "RJ", "ES", "SP", "SC", "RS", "PR"
            };

            var estacoes = new Dictionary<string, HashSet<string>>
            {
                { "Kum", new HashSet<string> { "SP", "SC", "RS" } },
                { "Kdois", new HashSet<string> { "RJ", "SP", "MT" } },
                { "Ktres", new HashSet<string> { "ES", "SC", "PR" } },
                { "Kquatro", new HashSet<string> { "SC", "RS" } },
                { "Kcinco", new HashSet<string> { "PR", "MS" } }
            };

            var selecionadas = new List<string>();

            while (estadosNecessarios.Count > 0)
            {
                string melhorEstacao = null;
                int melhorCobertura = 0;

                foreach (var estacao in estacoes)
                {
                    var coberturaAtual = estacao.Value.Count(e => estadosNecessarios.Contains(e));

                    if (coberturaAtual > melhorCobertura)
                    {
                        melhorCobertura = coberturaAtual;
                        melhorEstacao = estacao.Key;
                    }
                }

                if (melhorEstacao == null)
                    break;

                selecionadas.Add(melhorEstacao);

                foreach (var estado in estacoes[melhorEstacao])
                {
                    estadosNecessarios.Remove(estado);
                }

                estacoes.Remove(melhorEstacao);
            }

            Console.WriteLine("Estações selecionadas:");

            foreach (var estacao in selecionadas)
            {
                Console.WriteLine(estacao);
            }
        }
    }
}