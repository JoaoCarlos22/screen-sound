using System;
using ScreenSound.Models;
namespace ScreenSound.Menus
{
    internal class ListarBandas
    {
        internal void Exibir(Dictionary<string, Banda> bandas)
        {
            Console.Clear();
            Console.WriteLine("LISTA DE BANDAS\n");
            foreach (var banda in bandas)
            {
                string nome = banda.Value.Nome;
                List<Avaliacao> notas = banda.Value.Notas;
                Console.WriteLine("Banda: {0}, Notas: {1}", nome, string.Join(", ", notas.Select(n => n.Nota)));
            }
            Console.WriteLine("");
        }
    }
}
