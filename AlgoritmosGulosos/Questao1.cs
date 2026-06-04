using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosGulosos
{
    public static class Questao1
    {
        public static void Resolver()
        {
            int capacidadeCaminhao = 100;

            var itensVolume = new Dictionary<int, int>
            {
                {1, 40},
                {2, 30},
                {3, 25},
                {4, 20},
                {5, 15}
            };

            var itensSelecionados = new List<int>();
            int volumeAtual = 0;

            foreach (var item in itensVolume.OrderByDescending(i => i.Value))
            {
                if (volumeAtual + item.Value <= capacidadeCaminhao)
                {
                    itensSelecionados.Add(item.Key);
                    volumeAtual += item.Value;
                }
            }

            Console.WriteLine("itens selecionados:");
            foreach (var id in itensSelecionados)
            {
                Console.WriteLine($"item {id}");
            }

            Console.WriteLine($"\nvolume total: {volumeAtual}L");
        }
    }
}