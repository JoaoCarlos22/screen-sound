using System;

namespace ScreenSound.Models
{
    internal class Album : IAvaliavel
    {
        private List<Musica> musicas = new List<Musica>();
        private List<Avaliacao> notas = new();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public List<Musica> Musicas => musicas;
        public List<Avaliacao> Notas => notas;

        public double Media => notas.Count == 0 ? 0 : notas.Average(n => n.Nota);

        public Album(string nome)
        {
            Nome = nome;
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}
