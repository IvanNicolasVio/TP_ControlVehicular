﻿using BibliotecaEntidades.AdministradoresDeClases;
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

namespace Biblioteca_de_Formularios
{
    public partial class FrmViajes : Form
    {
        private int _viajes;

        public int Viajes
        {
            get { return _viajes; }
            set { _viajes = value; }
        }

        public FrmViajes()
        {
            InitializeComponent();
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            label_modificable.Text = AdmBitacora.ContarViajes().ToString();
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var numero = Validador.ValidarNumero(textBox1.Text);
                Validador.ValidarCantidadViajes(AdmBitacora.ContarViajes(), numero);
                Viajes = numero;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
