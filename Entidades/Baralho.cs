using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Baralho
    {
        public int IdBaralho { get; set; } //Deve ser único
        public string? Nome { get; set; }
        public List<Carta>? Cartas { get; set; }

        public Baralho()
        {

        }

        public Baralho(int idBaralho, string nome, List<Carta> cartas)
        {
            IdBaralho = idBaralho;
            Nome = nome;
            Cartas = cartas;
        }
    }
}
