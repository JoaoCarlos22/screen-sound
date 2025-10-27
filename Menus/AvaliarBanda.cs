using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AvaliarArtista: Menu
    {
        public override void Exibir(Dictionary<string, Artista> artistas)
        {
            base.Exibir(artistas);
            Console.WriteLine("AVALIAÇÃO DE UM ARTISTA");
            Console.Write("Digite o nome do artista que deseja avaliar: ");
            string nomeArtista = Console.ReadLine()!;

            Artista? artista;
            if (artistas.TryGetValue(nomeArtista, out artista))
            {
                Console.Write($"\nInforme a sua nota para o artista {nomeArtista}: ");
                Avaliacao nota = Avaliacao.Parser(Console.ReadLine()!);
                
                if (nota.Nota < 0 || nota.Nota > 10)
                {
                    Console.WriteLine("\nA nota deve ser entre 0 e 10!");
                } else
                {
                    artista.AdicionarNota(nota);
                    Console.WriteLine("\nAvaliação adicionada com sucesso!");
                }
            }
            else
            {
                Console.WriteLine($"\nO artista {nomeArtista} não foi encontrado!");
            }
        }
    }
}
