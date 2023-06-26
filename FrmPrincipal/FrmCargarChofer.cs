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
    public partial class FrmCargarChofer : Form
    {
        public FrmCargarChofer()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Boton que carga un chofer a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_cargar_Click(object sender, EventArgs e)
        {
            var choferes = new AdmChoferes();
            try
            {
                choferes.IngresarChofer(textBox_nombre.Text, textBox_apellido.Text, textBox_dni.Text, textBox_edad.Text);
                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Cargo un chofer");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Boton que sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Salio de la carga de choferes");
            Close();
        }
    }
}
