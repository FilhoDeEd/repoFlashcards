namespace Flashcards
{
    public partial class formVisualizarBaralhos : Form
    {
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
    }
}