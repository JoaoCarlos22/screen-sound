using System;

namespace ScreenSound.Models
{
    internal class Artista : IAvaliavel
    {
        private List<Album> albuns = new();
        private List<Avaliacao> notas = new();
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);
        public List<Album> Albuns => albuns;
        public List<Avaliacao> Notas => notas;

        public Artista(string nome, string biografia, List<Album> albuns)
        {
            Nome = nome;
            Biografia = biografia;
            this.albuns = albuns;
        }

        // Função para adicionar um album
        public void AdicionarAlbum(Album album)
        {
            if (album != null)
            {
                albuns.Add(album);
            }
        }

        // Função para adicionar uma nota
        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}
