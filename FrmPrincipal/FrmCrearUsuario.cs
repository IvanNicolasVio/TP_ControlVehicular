using BibliotecaEntidades.AdministradoresDeClases;
using BibliotecaEntidades.Clases;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void boton_crear_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarios = new AdmUsuarios();
                usuarios.CrearUsuario(textBox_nombreUsuario.Text, textBox_contrasenia.Text, comboBox_administrador.Text);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Creo un usuario");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Salio de la creacion de usuario");
            Close();
        }
    }
}
