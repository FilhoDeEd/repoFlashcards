using Flashcards.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Flashcards
{
    public partial class formVisualizarBaralhos : Form
    {
        public Baralho? BaralhoSelecionado { get; set; }

        public formVisualizarBaralhos()
        {
            InitializeComponent();
        }

        private void btnAdicionarBaralho_Click(object sender, EventArgs e)
        {
            formAdicionarBaralho adicionarBaralho = new formAdicionarBaralho();            
            adicionarBaralho.Show();
        }

        private void btnEditarBaralho_Click(object sender, EventArgs e)
        {
            formEditarBaralho editarBaralho = new formEditarBaralho();
            editarBaralho.Show();
        }

        private void btnBaralho1_Click(object sender, EventArgs e)
        {
            Carta[] Cartas = new Carta[1];

            Carta card1 = new Carta(1, "Qual a vantagem do método de Newton?", "Não sei", "MNUC4");

            Cartas[0] = card1;
            
            Baralho baralhoMNUC4 = new Baralho(1, "MNUC4", Cartas);

            BaralhoSelecionado = baralhoMNUC4;
        }

        private void btnBaralho2_Click(object sender, EventArgs e)
        {
            Carta[] Cartas = new Carta[1];

            Carta card2 = new Carta(2, "O que é o dotnet?", "Um framework da microsoft que contém diversas classe e " +
                "outros recursos de programação pré-prontos", "LPRC4");

            Cartas[0] = card2;

            Baralho baralhoLPRC4 = new Baralho(2, "LPRC4", Cartas);

            BaralhoSelecionado = baralhoLPRC4;
        }

        private void btnBaralho3_Click(object sender, EventArgs e)
        {
            Carta[] Cartas = new Carta[1];

            Carta card3 = new Carta(3, "O que faz a função fork?", "Cria um novo processo identico ao processo pai", "SOPC4");

            Cartas[0] = card3;

            Baralho baralhoSOPC4 = new Baralho(3, "SOPC4", Cartas);

            BaralhoSelecionado = baralhoSOPC4;
        }

        private void btnRevisarBaralho_Click_1(object sender, EventArgs e)
        {
            formTelaDeRevisao telaDeRevisao = new formTelaDeRevisao();
            telaDeRevisao.MdiParent = this.MdiParent;
            telaDeRevisao.BaralhoRevisar = this.BaralhoSelecionado;
            this.Close();
            telaDeRevisao.Show();
        }
    }
}