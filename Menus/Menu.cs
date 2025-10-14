using System;
using ScreenSound.Models;
namespace ScreenSound.Menus
{
    internal class Menu
    {
        public virtual void Exibir(Dictionary<string, Banda> bandas)
        {
            Console.Clear();
        }
    }
}
