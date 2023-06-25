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

            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Mostro la lista de vehiculos");
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            var admVehiculos = new AdmVehiculos();
            var vehiculos = (List<Vehiculo>)dataGridView1.DataSource;
            admVehiculos.EditarVehiculo(vehiculos);

            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Edito la lista de vehiculos");
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

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Borro un vehiculo");
            }
        }

        private void boton_exp_csv_Click(object sender, EventArgs e)
        {

            try
            {
                var datosDataGrid = (List<Vehiculo>)dataGridView1.DataSource;
                Informes<Vehiculo>.GuardarCSV(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto lista de vehiculos a CSV");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        private void boton_exp_json_Click(object sender, EventArgs e)
        {
            
            try
            {
                var datosDataGrid = (List<Vehiculo>)dataGridView1.DataSource;
                Informes<Vehiculo>.GuardarJson(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto lista de vehiculos a JSON");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }
        }
    }
}
