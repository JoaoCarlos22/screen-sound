using System;

namespace ScreenSound.Models
{
    public class Banda
    {
        private List<Album> albuns = new();
        private List<int> notas = new();

        public Banda(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public double Media => notas.Count == 0 ? 0 : notas.Average();
        public List<Album> Albuns => albuns;
        public List<int> Notas => notas;

        // Função para adicionar um album
        public void AdicionarAlbum(Album album)
        {
            if (album != null)
            {
                albuns.Add(album);
            }
        }

        // Função para adicionar uma nota
        public void AdicionarNota(int nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                notas.Add(nota);
            }
        }
    }
}
