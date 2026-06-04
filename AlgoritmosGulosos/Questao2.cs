using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosGulosos
{
    public static class Questao2
    {
        public static void Resolver()
        {
            int diasDisponiveis = 7;

            var locais = new List<(string Nome, int Valor, int Tempo)>
            {
                ("Museu", 10, 2),
                ("Torre", 18, 5),
                ("Parque", 8, 1),
                ("Castelo", 2, 3)
            };

            var locaisPrioridade = locais
                .OrderByDescending(l => (double)l.Valor / l.Tempo)
                .ToList();

            var locaisSelecionados = new List<(string Nome, int Valor, int Tempo)>();
            int tempoUsado = 0;

            foreach (var local in locaisPrioridade)
            {
                if (tempoUsado + local.Tempo <= diasDisponiveis)
                {
                    locaisSelecionados.Add(local);
                    tempoUsado += local.Tempo;
                }
            }

            Console.WriteLine("locais selecionados:");

            foreach (var local in locaisSelecionados)
            {
                Console.WriteLine($"{local.Nome} (Valor {local.Valor}, Tempo {local.Tempo})");
            }

            int totalValor = locaisSelecionados.Sum(l => l.Valor);
            Console.WriteLine($"\nTotal de pontos: {totalValor} em {tempoUsado} dias");
        }
    }
}