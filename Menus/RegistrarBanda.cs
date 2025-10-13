using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class RegistrarBanda
    {
        internal void Exibir(Dictionary<string, Banda> bandas)
        {
            Console.Clear();
            Console.WriteLine("REGISTRO DE BANDAS");
            Console.Write("Digite o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            Banda banda = new(nomeBanda);

            Console.WriteLine($"A banda {banda.Nome} foi registrada com sucesso!");
            bandas.Add(banda.Nome, banda);
        }
    }
}
