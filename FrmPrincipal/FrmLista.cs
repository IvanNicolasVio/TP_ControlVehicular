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
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }

        private void boton_mostrar_Click(object sender, EventArgs e)
        {
            var json = new ManejadorVehiculosJson();
            var vehiculos = json.ObtenerDatos();
            dataGridView1.DataSource = vehiculos;
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            var json = new ManejadorVehiculosJson();
            var vehiculos = json.ObtenerDatos();
            vehiculos = (List<Vehiculo>)dataGridView1.DataSource;
            json.Guardar(vehiculos);
        }
    }
}
