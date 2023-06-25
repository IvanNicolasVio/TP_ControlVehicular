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
    public partial class FrmCargarV : Form
    {
        public FrmCargarV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vehiculos = new AdmVehiculos();
            try
            {
                vehiculos.IngresarVehiculo(txtBox_patente.Text, box_tipo.Text, box_marca.Text, txtBox_modelo.Text, txtBox_kilometros.Text);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Cargo un vehiculo");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
