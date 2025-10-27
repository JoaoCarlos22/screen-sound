using System;

namespace ScreenSound.Models
{
    internal class Musica
    {
        public Musica(string nome, int duracao, Artista artista)
        {
            Nome = nome;
            Duracao = duracao;
            Artista = artista;
        }

        public string Nome { get; }
        public Artista Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string Descricao => $"A música {Nome} pertence à banda {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel == true)
            {
                Console.WriteLine("Disponível: Sim");
            }
            else
            {
                Console.WriteLine($"Disponível: Não");
            }
        }
    }
}
