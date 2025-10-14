using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class ExibirDetalhes: Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("EXIBIR DETALHES DE UMA BANDA");
            Console.Write("Digite o nome da banda que deseja ver os detalhes: ");
            string nomeBanda = Console.ReadLine()!;

            if (bandas.ContainsKey(nomeBanda))
            {
                Banda banda = bandas[nomeBanda];
                Console.WriteLine($"\nDetalhes da banda {banda.Nome}:");

                if (banda.Notas.Count > 0)
                {
                    Console.WriteLine("Avaliações:");
                    foreach (var avaliacao in banda.Notas)
                    {
                        Console.WriteLine($"- Nota: {avaliacao.Nota}");
                    }

                    Console.WriteLine($"Média das avaliações: {banda.Media:F2}");
                }
                else
                {
                    Console.WriteLine("Essa banda ainda não possui avaliações.");
                }
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
            }
        }
    }
}
