using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class RegistrarArtista: Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("REGISTRO DE ARTISTAS");
            Console.Write("Digite o nome do artista: ");
            string nomeArtista = Console.ReadLine()!;
            Console.Write("Digite a biografia do artista: ");
            string biografiaArtista = Console.ReadLine()!;
            Artista artista = new(nomeArtista, biografiaArtista, new List<Album>());

            Console.WriteLine($"O artista {artista.Nome} foi registrado com sucesso!");
            artistas.Add(artista.Nome, artista);
        }
    }
}
