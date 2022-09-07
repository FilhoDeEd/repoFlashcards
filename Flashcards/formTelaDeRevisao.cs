using Flashcards.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class formTelaDeRevisao : Form
    {
        public Baralho? BaralhoRevisar { get; set; }

        public formTelaDeRevisao()
        {
            InitializeComponent();
        }

        private void formTelaDeRevisao_Load(object sender, EventArgs e)
        {
            if(BaralhoRevisar != null)
            {
                this.lblDisciplinaTelaDeRevisao.Text = BaralhoRevisar.Cartas[0].Disciplina;
                this.lblBaralhoTelaDeRevisao.Text = BaralhoRevisar.Nome;
                this.txtPerguntaTelaDeRevisao.Text = BaralhoRevisar.Cartas[0].Pergunta;
                this.rtxtRespostaTelaDeRevisao.Text = "";
            }
        }

        private void btnRespotaTelaDeRevisao_Click(object sender, EventArgs e)
        {
            if(BaralhoRevisar != null)
            {
                this.rtxtRespostaTelaDeRevisao.Text = BaralhoRevisar.Cartas[0].Resposta;
            }
        }

        private void formTelaDeRevisao_FormClosed(object sender, FormClosedEventArgs e)
        {
            formVisualizarBaralhos visualizarBaralhos = new formVisualizarBaralhos();
            visualizarBaralhos.MdiParent = this.MdiParent;
            visualizarBaralhos.Show();
        }
    }
}
