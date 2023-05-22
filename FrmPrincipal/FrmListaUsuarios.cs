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
    public partial class FrmListaUsuarios : Form
    {
        public FrmListaUsuarios()
        {
            InitializeComponent();
            OrdenarFrm();
        }

        internal void OrdenarFrm()
        {
            var json = new ManejadorUsuarioJson();
            var usuarios = json.ObtenerDatos();
            dataGridView1.DataSource = usuarios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Usuario selectedData = (Usuario)selectedRow.DataBoundItem;
                string name = selectedData.Nombre.ToString();
                string password = selectedData.Contrasenia.ToString();
                bool isAdmin = selectedData.Administrador;
                // Mostrar los valores en los TextBox
                textBox_usuario.Text = name;
                textBox_contrasenia.Text = password;
                if (isAdmin)
                {
                    comboBox_administrador.TabIndex = 0;
                }
                else
                {
                    comboBox_administrador.TabIndex = 1;
                };

            }
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var json = new ManejadorUsuarioJson();
                var usuarios = json.ObtenerDatos();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Usuario selectedData = (Usuario)selectedRow.DataBoundItem;
                foreach (var usuario in usuarios)
                {
                    if (usuario == selectedData)
                    {
                        usuarios.Remove(usuario);
                        break;
                    }
                }
                json.Guardar(usuarios);
                dataGridView1.DataSource = usuarios;
            }
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var json = new ManejadorUsuarioJson();
                var usuarios = json.ObtenerDatos();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Usuario selectedData = (Usuario)selectedRow.DataBoundItem;
                try 
                {
                foreach (var usuario in usuarios)
                {
                    if (usuario == selectedData)
                    {
                        usuario.editarUsuario(textBox_usuario.Text, textBox_contrasenia.Text, comboBox_administrador.Text);

                        break;
                    }
                }
                json.Guardar(usuarios);
                dataGridView1.DataSource = usuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
