using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Classes
{
    public class Baralho
    {
        public int IdBaralho { get; set; } //Deve ser único
        public string Nome { get; set; }
        public Carta[] Cartas { get; set; }

        public Baralho(int idBaralho, string nome, Carta[] cartas)
        {
            IdBaralho = idBaralho;
            Nome = nome;
            Cartas = cartas;
        }
    }
}
