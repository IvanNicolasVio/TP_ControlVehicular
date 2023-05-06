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
            var json = new AdministradorJson< List<Usuario> >("C:\\Users\\Iván\\source\\repos\\TP_ControlVehicular\\BibliotecaEntidades\\usuarios.json");
            var usuarios = json.ObtenerDatos();

            foreach(Usuario usuarioDeLista in usuarios) 
            {
                if (txtBox_usuario.Text == usuarioDeLista.Nombre && txtBox_contrasenia.Text == usuarioDeLista.Contrasenia)
                {
                    var frmContendor = new FrmContenedor();
                    frmContendor.ShowDialog();
                    Hide();

                    break;
                }
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
