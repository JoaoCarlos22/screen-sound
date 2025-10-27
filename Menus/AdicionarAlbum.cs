using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AdicionarAlbum : Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("ADICIONAR ÁLBUM A UM ARTISTA");
            Console.Write("Digite o nome do artista: ");
            string nomeArtista = Console.ReadLine()!;
            if (!artistas.ContainsKey(nomeArtista))
            {
                Console.WriteLine($"Artista {nomeArtista} não encontrado.");
                return;
            }

            Artista artista = artistas[nomeArtista];
            Console.Write("Digite o nome do álbum: ");
            string nomeAlbum = Console.ReadLine()!;
            artista.AdicionarAlbum(new Album(nomeAlbum));
            Console.WriteLine($"Álbum {nomeAlbum} do artista {nomeArtista} foi adicionado com sucesso!");
        }
    }
}
