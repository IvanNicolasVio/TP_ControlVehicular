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
            var formLista = new FrmLista();

            formLista.ShowDialog();
        }

        private void nuevoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCargarV = new FrmCargarV();
            formCargarV.ShowDialog();
        }
    }
}