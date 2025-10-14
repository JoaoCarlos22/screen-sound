using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AvaliarAlbum : Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("AVALIAÇÃO DE UM ÁLBUM");
            Console.Write("Digite o nome da banda dona do álbum que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (!bandas.ContainsKey(nomeBanda))
            {
                Console.WriteLine("Banda não encontrada.");
                return;
            }

            Banda banda = bandas[nomeBanda];
            Console.Write("Digite o nome do álbum que deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            if (!banda.Albuns.Any(a => a.Nome.Equals(nomeAlbum)))
            {
                Console.WriteLine("Álbum não encontrado.");
                return;
            }
            Album album = banda.Albuns.First(a => a.Nome.Equals(nomeAlbum));
            Console.Write("Digite a nota (0 a 10): ");
            Avaliacao nota = Avaliacao.Parser(Console.ReadLine()!);
            album.AdicionarNota(nota);
            Console.WriteLine("Avaliação adicionada com sucesso!");
        }
    }
}
