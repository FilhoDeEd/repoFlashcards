using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Flashcards
{
    public partial class formEditarBaralho : Form
    {
        public formEditarBaralho()
        {
            InitializeComponent();
        }

        private void formEditarBaralho_Load(object sender, EventArgs e)
        {
            List<Baralho> baralhos = new List<Baralho>();

            List<Carta> Cartas1 = new List<Carta>();
            Carta card1 = new Carta(1, "Qual a vantagem do método de Newton?", "Não sei", "MNUC4");
            Cartas1.Add(card1);
            Baralho baralhoMNUC4 = new Baralho(1, "MNUC4", Cartas1);
            baralhos.Add(baralhoMNUC4);


            List<Carta> Cartas2 = new List<Carta>();
            Carta card2 = new Carta(2, "O que é o dotnet?", "Um framework da microsoft que contém diversas classe e " +
                "outros recursos de programação pré-prontos", "LPRC4");
            Cartas2.Add(card2);
            Baralho baralhoLPRC4 = new Baralho(2, "LPRC4", Cartas2);
            baralhos.Add(baralhoLPRC4);



            List<Carta> Cartas3 = new List<Carta>();
            Carta card3 = new Carta(3, "O que faz a função fork?", "Cria um novo processo identico ao processo pai", "SOPC4");
            Cartas3.Add(card3);
            Baralho baralhoSOPC4 = new Baralho(3, "SOPC4", Cartas3);
            baralhos.Add(baralhoSOPC4);

            this.dataGridView1.DataSource = baralhos;
        }
    }
}
