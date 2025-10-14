using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class AdicionarAlbum : Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("ADICIONAR ÁLBUM A UMA BANDA");
            Console.Write("Digite o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            if (!bandas.ContainsKey(nomeBanda))
            {
                Console.WriteLine($"Banda {nomeBanda} não encontrada.");
                return;
            }

            Banda banda = bandas[nomeBanda];
            Console.Write("Digite o nome do álbum: ");
            string nomeAlbum = Console.ReadLine()!;
            banda.AdicionarAlbum(new Album(nomeAlbum));
            Console.WriteLine($"Álbum {nomeAlbum} da banda {nomeBanda} foi adicionado com sucesso!");
        }
    }
}
