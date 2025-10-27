using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AdicionarMusica : Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("ADICIONAR MÚSICA A UM ÁLBUM");
            Console.Write("Digite o nome do artista dono do álbum: ");
            string nomeArtista = Console.ReadLine()!;
            if (!artistas.ContainsKey(nomeArtista))
            {
                Console.WriteLine("Artista não encontrado.");
                return;
            }

            Artista artista = artistas[nomeArtista];
            Console.Write("Digite o nome do álbum que deseja adicionar a música: ");
            string nomeAlbum = Console.ReadLine()!;
            if (!artista.Albuns.Any(a => a.Nome.Equals(nomeAlbum)))
            {
                Console.WriteLine("Álbum não encontrado.");
                return;
            }
            Album album = artista.Albuns.First(a => a.Nome.Equals(nomeAlbum));
            Console.Write("Digite o nome da música: ");
            string nomeMusica = Console.ReadLine()!;

            Console.Write("Digite a duração da música em segundos: ");
            int duracao = int.Parse(Console.ReadLine()!);
            Musica musica = new(nomeMusica, duracao, artista);
            album.AdicionarMusica(musica);
            Console.WriteLine("Música adicionada com sucesso!");
        }
    }
}
