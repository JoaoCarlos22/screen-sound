using System;

namespace ScreenSound.Models
{
    internal class Banda : IAvaliavel
    {
        private List<Album> albuns = new();
        private List<Avaliacao> notas = new();

        public Banda(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);
        public List<Album> Albuns => albuns;
        public List<Avaliacao> Notas => notas;

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
