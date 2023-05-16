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
using System.Xml.Linq;

namespace FrmPrincipal
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
            OrdenarFrm();

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



        private void OrdenarFrm()
        {
            if (ManejadorUsuarioJson.UsuarioActivo!.Administrador)
            {
                boton_editar.Enabled = true;
                boton_borrar.Enabled = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                boton_editar.Enabled = false;
                boton_borrar.Enabled = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Vehiculo selectedData = (Vehiculo)selectedRow.DataBoundItem;
                ((List<Vehiculo>)dataGridView1.DataSource).Remove(selectedData);
                dataGridView1.Refresh();
            }
        }
    }
}
