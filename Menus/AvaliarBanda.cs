using System;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    public class AvaliarBanda
    {
        internal void Exibir(Dictionary<string, Banda> bandas)
        {
            Console.Clear();
            Console.WriteLine("AVALIAÇÃO DE UMA BANDA");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;

            Banda? banda;
            if (bandas.TryGetValue(nomeBanda, out banda))
            {
                Console.Write($"\nInforme a sua nota para a banda {nomeBanda}: ");
                Avaliacao nota = Avaliacao.Parser(Console.ReadLine()!);
                banda.AdicionarNota(nota);

                if (nota.Nota < 0 || nota.Nota > 10)
                {
                    Console.WriteLine("\nA nota deve ser entre 0 e 10!");
                } else
                {
                    Console.WriteLine("\nAvaliação adicionada com sucesso!");
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            }
        }
    }
}
