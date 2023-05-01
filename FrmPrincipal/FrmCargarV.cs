using FrmPrincipal.Clases;
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
            int km;
            bool esNumero = int.TryParse(txtBox_kilometros.Text, out km);
            if (km > 0 && txtBox_marca.Text is string && txtBox_modelo.Text is string && txtBox_tipo.Text is string && (txtBox_patente.TextLength == 6 || txtBox_patente.TextLength == 7))
            {
                var vehiculo = new Vehiculo(txtBox_patente.Text, txtBox_tipo.Text, txtBox_marca.Text, txtBox_modelo.Text, km);
                Close();
            }
            else
            {
                MessageBox.Show("DATOS ERRONEOS");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
