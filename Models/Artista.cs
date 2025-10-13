using System;

namespace ScreenSound.Models
{
    public class Artista
    {
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public List<Album> albuns = new List<Album>();

        public Artista(string nome, string biografia, List<Album> albuns)
        {
            Nome = nome;
            Biografia = biografia;
            this.albuns = albuns;
        }
    }
}
