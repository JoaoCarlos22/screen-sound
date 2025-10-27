using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class ExibirDetalhes : Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("EXIBIR DETALHES DE UM ARTISTA");
            Console.Write("Digite o nome do artista que deseja ver os detalhes: ");
            string nomeArtista = Console.ReadLine()!;

            Artista? artista;
            if (!artistas.TryGetValue(nomeArtista, out artista))
            {
                Console.WriteLine($"O artista {nomeArtista} não foi encontrado.");
                return;
            }

            Console.WriteLine($"\nDetalhes do artista {artista.Nome}:");
            ExibirAvaliacoes("Avaliações", artista.Notas, artista.Media);

            if (artista.Albuns.Count > 0)
            {
                Console.WriteLine("\nÁlbuns:");
                foreach (var album in artista.Albuns)
                {
                    Console.WriteLine($"- {album.Nome}");
                    ExibirAvaliacoes("  Avaliações", album.Notas, album.Media, "  ");
                }

                Console.WriteLine("\nMúsicas:");
                foreach (var album in artista.Albuns)
                {
                    foreach (var musica in album.Musicas)
                    {
                        Console.WriteLine($"- {musica.Nome}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Esse artista ainda não possui álbuns.");
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
