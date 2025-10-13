using System;

namespace ScreenSound.Models
{
    internal class Avaliacao
    {
        public int Nota { get; }
        public Avaliacao(int nota)
        {
            if (nota < 0 || nota > 10) return;
            Nota = nota;
        }
    }
}
