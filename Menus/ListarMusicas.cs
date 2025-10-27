using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class ListarMusicas : Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("LISTAR MÚSICAS DE UM ARTISTA");

            Console.Write("Digite o nome do artista: ");
            string nomeDoArtista = Console.ReadLine()!;

            if (!artistas.ContainsKey(nomeDoArtista))
            {
                Console.WriteLine("Artista não encontrado.");
                return;
            }

            Artista artista = artistas[nomeDoArtista];

            Console.WriteLine($"\nMúsicas do artista {artista.Nome}:");

            foreach (var album in artista.Albuns)
            {
                Console.WriteLine($"\nÁlbum: {album.Nome}");

                foreach (var musica in album.Musicas)
                {
                    Console.WriteLine($"- {musica.Nome} ({musica.Duracao / 60} min)");
                }
            }
        }
    }
}
