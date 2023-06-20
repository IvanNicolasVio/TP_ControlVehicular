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
            var admVehiculos = new AdmVehiculos();
            var vehiculos = admVehiculos.TraerLista();
            dataGridView1.DataSource = vehiculos;
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            var admVehiculos = new AdmVehiculos();
            var vehiculos = (List<Vehiculo>)dataGridView1.DataSource;
            admVehiculos.EditarVehiculo(vehiculos);
        }



        private void OrdenarFrm()
        {
            if (AdmUsuarios.UsuarioActivo!.Administrador)
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
                var admVehiculos = new AdmVehiculos();
                var vehiculos = admVehiculos.TraerLista();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Vehiculo selectedData = (Vehiculo)selectedRow.DataBoundItem;
                foreach (var vehiculo in vehiculos)
                {
                    if (vehiculo == selectedData)
                    {
                        admVehiculos.Borrar(vehiculo);
                        break;
                    }
                }

                dataGridView1.Columns.Clear();
            }
        }
    }
}
