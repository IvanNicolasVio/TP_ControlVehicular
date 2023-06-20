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

        private void boton_mostrar_Click(object sender, EventArgs e)
        {
            //var json = new ManejadorChoferJson();
            //var choferes = json.ObtenerDatos();
            var admChoferes = new AdmChoferes();
            var choferes = admChoferes.TraerLista();
            dataGridView1.DataSource = choferes;
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            var admChoferes = new AdmChoferes();
            var choferes = (List<Persona>)dataGridView1.DataSource;
            admChoferes.EditarChofer(choferes);
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var admChofer = new AdmChoferes();
                var choferes = admChofer.TraerLista();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Persona selectedData = (Persona)selectedRow.DataBoundItem;
                foreach (var chofer in choferes) 
                {
                    if(chofer == selectedData) 
                    {
                        admChofer.Borrar(chofer);
                        break;
                    }
                }

                dataGridView1.Columns.Clear();
            }
            
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
    }


}
