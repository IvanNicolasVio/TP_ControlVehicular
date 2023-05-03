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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            var usuario = new Usuario("Ivan", "1234", true);
            var usuarioDos = new Usuario("Lautaro", "1234", false);
            usuarios.Add(usuario);
            usuarios.Add(usuarioDos);

            foreach(Usuario usario in usuarios) 
            {
                if (txtBox_usuario.Text == usuario.Nombre && txtBox_contrasenia.Text == usuario.Contrasenia)
                {
                    var frmContendor = new FrmContenedor();
                    frmContendor.ShowDialog();
                    Hide();
                }
                break;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
