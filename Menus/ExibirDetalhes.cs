using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class ExibirDetalhes : Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("EXIBIR DETALHES DE UMA BANDA");
            Console.Write("Digite o nome da banda que deseja ver os detalhes: ");
            string nomeBanda = Console.ReadLine()!;

            if (!bandas.TryGetValue(nomeBanda, out Banda? banda))
            {
                Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
                return;
            }

            Console.WriteLine($"\nDetalhes da banda {banda.Nome}:");
            ExibirAvaliacoes("Avaliações", banda.Notas, banda.Media);

            if (banda.Albuns.Count > 0)
            {
                Console.WriteLine("\nÁlbuns:");
                foreach (var album in banda.Albuns)
                {
                    Console.WriteLine($"- {album.Nome}");
                    ExibirAvaliacoes("  Avaliações", album.Notas, album.Media, "  ");
                }
            }
            else
            {
                Console.WriteLine("Essa banda ainda não possui álbuns.");
            }
        }

        private void ExibirAvaliacoes(string titulo, List<Avaliacao> notas, double media, string indent = "")
        {
            if (notas.Count > 0)
            {
                Console.WriteLine($"{indent}{titulo}:");
                foreach (var avaliacao in notas)
                {
                    Console.WriteLine($"{indent}- Nota: {avaliacao.Nota}");
                }
                Console.WriteLine($"{indent}Média das avaliações: {media:F2}");
            }
            else
            {
                Console.WriteLine($"{indent}Ainda não possui avaliações.");
            }
        }
    }
}
