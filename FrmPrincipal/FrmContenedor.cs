namespace FrmPrincipal
{
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
        }

        private void listaVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLista = new FrmContenedor();

            formLista.ShowDialog();
        }
    }
}