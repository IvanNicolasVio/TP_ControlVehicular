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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HacerLogin();
            }
            catch
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ingresa el usuario, si es valido, abre el form principal
        /// </summary>
        private void HacerLogin()
        {
            var json = new ManejadorUsuarioJson();
            var usuario = json.Login(txtBox_usuario.Text, txtBox_contrasenia.Text);
            var formPrincipal = new FrmContenedor(this);
            formPrincipal.ShowDialog();
            
        }

    }
}
