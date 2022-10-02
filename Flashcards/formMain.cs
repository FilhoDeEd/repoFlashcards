using Flashcards.formsBaralhos;
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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            formVisualizarBaralhos visualizarBaralhos = new formVisualizarBaralhos();
            visualizarBaralhos.MdiParent = this;
            visualizarBaralhos.Show();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdicionarCarta adicionarCarta = new formAdicionarCarta();
            adicionarCarta.ShowDialog();

            if (adicionarCarta.DialogResult == DialogResult.OK)
            {

            }
            else if (adicionarCarta.DialogResult == DialogResult.Cancel)
            { 

            }
        }
    }
}
