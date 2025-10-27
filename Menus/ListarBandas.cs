using System;
using ScreenSound.Models;
namespace ScreenSound.Menus
{
    internal class ListarArtistas: Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("LISTA DE ARTISTAS\n");
            foreach (var artista in artistas)
            {
                string nome = artista.Value.Nome;
                List<Avaliacao> notas = artista.Value.Notas;
                Console.WriteLine("Artista: {0}, Notas: {1}", nome, string.Join(", ", notas.Select(n => n.Nota)));
            }
            Console.WriteLine("");
        }
    }
}
