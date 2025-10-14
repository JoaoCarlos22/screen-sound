using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class RegistrarBanda: Menu
    {
        public override void Exibir(Dictionary<string, Banda> bandas)
        {
            base.Exibir(bandas);
            Console.WriteLine("REGISTRO DE BANDAS");
            Console.Write("Digite o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = new(nomeBanda);

            Console.WriteLine($"A banda {banda.Nome} foi registrada com sucesso!");
            bandas.Add(banda.Nome, banda);
        }
    }
}
