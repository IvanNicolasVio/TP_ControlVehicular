using Clases;

namespace FrmPrincipal
{
    public partial class FrmContenedor : Form
    {

        public FrmContenedor()
        {
            InitializeComponent();
            organizarFormulario();
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

        private void organizarFormulario()
        {

            txt_usuario.Text = "Nombre: " + ManejadorUsuarioJson.UsuarioActivo!.Nombre;
            if (ManejadorUsuarioJson.UsuarioActivo.Administrador)
            {
                txt_tipoUsuario.Text = "Tipo de usuario: Administrador";
            }
            else
            {
                txt_tipoUsuario.Text = "Tipo de usuario: Normal";
            }

        }

        private void listaDeChoferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formListaChoferes = new FrmListaChofer();
            formListaChoferes.ShowDialog();

        }

        private void nuevoChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCargarChofer = new FrmCargarChofer();
            frmCargarChofer.ShowDialog();
        }
    }
}