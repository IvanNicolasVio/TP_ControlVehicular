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
using BibliotecaEntidades.AdministradoresSQL;
using BibliotecaEntidades.AdministradoresDeClases;
using BibliotecaEntidades.Clases;

namespace FrmPrincipal
{
    public partial class FrmListaUsuarios : Form
    {
        public FrmListaUsuarios()
        {
            InitializeComponent();
            OrdenarFrm();
        }

        /// <summary>
        /// Ordena el formulario trayendo la lista de usuarios
        /// </summary>
        internal void OrdenarFrm()
        {
            var admUsuarios = new AdmUsuarios();
            var usuarios = admUsuarios.TraerLista();
            dataGridView1.DataSource = usuarios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_salir_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Salio de la lista de usuarios");
            Close();
        }


        /// <summary>
        /// Muestra los valores de un usuario seleccionado de la lista en dos textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Usuario selectedData = (Usuario)selectedRow.DataBoundItem;
                string name = selectedData.Nombre.ToString();
                string password = selectedData.Contrasenia.ToString();
                bool isAdmin = selectedData.Administrador;
                textBox_usuario.Text = name;
                textBox_contrasenia.Text = password;

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Trajo un usuario");

            }


        }

        /// <summary>
        /// Borra un usuario seleccionado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var admUsuarios = new AdmUsuarios();
                var usuarios = admUsuarios.TraerLista();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Usuario selectedData = (Usuario)selectedRow.DataBoundItem;
                foreach (var usuario in usuarios)
                {
                    if (usuario == selectedData)
                    {
                        admUsuarios.Borrar(usuario);
                        break;
                    }
                }
                dataGridView1.Columns.Clear();
                OrdenarFrm();

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Borro un usuario");
            }
        }

        /// <summary>
        /// Exporta la lista de usuarios en un csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_exp_csv_Click(object sender, EventArgs e)
        {
            
            try
            {
                var datosDataGrid = (List<Usuario>)dataGridView1.DataSource;
                Informes<Usuario>.GuardarCSV(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto lista de usuarios a CSV");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }
        }


        /// <summary>
        /// Exporta la lista de usuarios en un csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_exp_json_Click(object sender, EventArgs e)
        {
            
            try
            {
                var datosDataGrid = (List<Usuario>)dataGridView1.DataSource;
                Informes<Usuario>.GuardarJson(datosDataGrid);

                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto lista de usuarios a JSON");
            }
            catch (Exception)
            {
                MessageBox.Show("La lista esta vacia");
            }
        }
    }
}
