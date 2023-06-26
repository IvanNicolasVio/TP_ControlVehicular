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

namespace FrmPrincipal
{
    public partial class FrmListaChofer : Form
    {
        public FrmListaChofer()
        {
            InitializeComponent();
            OrdenarFrm();
        }


        /// <summary>
        /// Muesta la lista de choferes en un datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_mostrar_Click(object sender, EventArgs e)
        {
            var admChoferes = new AdmChoferes();
            var choferes = admChoferes.TraerLista();
            dataGridView1.DataSource = choferes;

            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Mostro la lista de choferes");
        }

        /// <summary>
        /// Luego de editar el datagrid, se usa para guardar la lista editada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_editar_Click(object sender, EventArgs e)
        {
            var admChoferes = new AdmChoferes();
            var choferes = (List<Persona>)dataGridView1.DataSource;
            admChoferes.EditarChofer(choferes);

            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Edito la lista de choferes");
        }


        /// <summary>
        /// Elimina la fila que este seleccionada en el datagrid y en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var admChofer = new AdmChoferes();
                var choferes = admChofer.TraerLista();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Persona selectedData = (Persona)selectedRow.DataBoundItem;
                admChofer.EliminarChofer(choferes, selectedData);
                dataGridView1.Columns.Clear();
            }
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Elimino un chofer");

        }

        /// <summary>
        /// Ordena el formulario, si el Usuario es administrador activa algunos botones, si no, los desactiva
        /// </summary>
        internal void OrdenarFrm()
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


        /// <summary>
        /// exporta un json de la lista de choferes a la pc del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_exp_json_Click(object sender, EventArgs e)
        {
            try
            {
                var datosDataGrid = (List<Persona>)dataGridView1.DataSource;
                Informes<Persona>.GuardarJson(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto un Json de choferes");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }

        }

        /// <summary>
        /// exporta un csv de la lista de choferes a la pc del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_exp_csv_Click(object sender, EventArgs e)
        {
            try
            {
                var datosDataGrid = (List<Persona>)dataGridView1.DataSource;
                Informes<Persona>.GuardarCSV(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto un CSV de choferes");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }
        }
    }


}
