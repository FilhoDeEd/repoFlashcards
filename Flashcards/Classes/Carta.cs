using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Classes
{
    public class Carta
    {
        public int IdCarta { get; set; } //Deve ser único
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public string Disciplina { get; set; }

        public Carta(int idCarta, string pergunta, string resposta, string disciplina)
        {
            IdCarta = idCarta;
            Pergunta = pergunta;
            Resposta = resposta;
            Disciplina = disciplina;
        }
    }
}
