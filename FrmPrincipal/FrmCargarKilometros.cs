﻿using Clases;
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
    public partial class FrmCargarKilometros : Form
    {
        private int _kilometros;
        private Vehiculo _vehiculo;

        public FrmCargarKilometros(Vehiculo vehiculo)
        {
            InitializeComponent();
            _vehiculo = vehiculo;
        }

        public int Kilometros
        {
            get { return _kilometros; }
            set { _kilometros = value; }
        }

        private void boton_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                var km = Validador.ValidarKilometros(textBox_km.Text);
                Validador.ValidarKmAnteriores(_vehiculo, km);
                Kilometros = km;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCargarKilometros_Load_1(object sender, EventArgs e)
        {
            label2.Text = $"KM anteriores: {_vehiculo.Kilometros}";
        }
    }
}