namespace Flashcards
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAdicionarBaralho_Click(object sender, EventArgs e)
        {
            formAdicionarBaralho AdicionarBaralho = new formAdicionarBaralho();            
            AdicionarBaralho.Show();
        }

        private void btnEditarBaralho_Click(object sender, EventArgs e)
        {
            formEditarBaralho EditarBaralho = new formEditarBaralho();
            EditarBaralho.Show();
        }
    }
}