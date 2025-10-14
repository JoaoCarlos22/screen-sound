using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class ExibirMediaBanda : Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("MÉDIA DE AVALIAÇÃO DE UMA BANDA");
            Console.Write("Digite o nome da banda que deseja buscar: ");
            string nomeBanda = Console.ReadLine()!;

            Banda? banda;
            if (bandas.TryGetValue(nomeBanda, out banda))
            {
                double media = banda.Media;
                Console.Write($"\nA banda {nomeBanda} tem uma média de avaliação de: {media}\n");
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            }
        }
    }
}
