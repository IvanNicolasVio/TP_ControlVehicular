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
            var json = new ManejadorUsuarioJson();
            var usuarios = json.ObtenerDatos();
            json.MostrarLabels(txt_usuario.Text,txt_tipoUsuario.Text);

            
        }
    }
}