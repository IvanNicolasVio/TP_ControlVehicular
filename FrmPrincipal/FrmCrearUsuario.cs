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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
