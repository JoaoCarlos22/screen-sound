using System;

namespace ScreenSound.Models
{
    internal class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public List<Musica> Musicas => musicas;

        public Album(string nome)
        {
            Nome = nome;
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
    }
}
