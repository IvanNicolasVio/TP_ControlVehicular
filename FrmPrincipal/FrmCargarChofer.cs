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
    public partial class FrmCargarChofer : Form
    {
        public FrmCargarChofer()
        {
            InitializeComponent();
        }


        private void boton_cargar_Click(object sender, EventArgs e)
        {
            var choferes = new AdmChoferes();
            try
            {
                choferes.IngresarChofer(textBox_nombre.Text, textBox_apellido.Text, textBox_dni.Text, textBox_edad.Text);
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
