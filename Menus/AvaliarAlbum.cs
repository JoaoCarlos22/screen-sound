using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AvaliarAlbum : Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("AVALIAÇÃO DE UM ÁLBUM");
            Console.Write("Digite o nome do artista dono do álbum que deseja avaliar: ");
            string nomeArtista = Console.ReadLine()!;
            if (!artistas.ContainsKey(nomeArtista))
            {
                Console.WriteLine("Artista não encontrado.");
                return;
            }

            Artista artista = artistas[nomeArtista];
            Console.Write("Digite o nome do álbum que deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            if (!artista.Albuns.Any(a => a.Nome.Equals(nomeAlbum)))
            {
                Console.WriteLine("Álbum não encontrado.");
                return;
            }
            Album album = artista.Albuns.First(a => a.Nome.Equals(nomeAlbum));
            Console.Write("Digite a nota (0 a 10): ");
            Avaliacao nota = Avaliacao.Parser(Console.ReadLine()!);
            album.AdicionarNota(nota);
            Console.WriteLine("Avaliação adicionada com sucesso!");
        }
    }
}
