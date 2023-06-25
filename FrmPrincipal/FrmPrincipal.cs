using Biblioteca_de_Formularios;
using BibliotecaEntidades.AdministradoresDeClases;
using BibliotecaEntidades.Clases;
using Clases;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmPrincipal
{
    public partial class FrmContenedor : Form
    {
        private bool _botonActivo = false;
        private Form1 _form1;
        public FrmContenedor(Form1 form1)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Inicio sesion");
            InitializeComponent();
            _form1 = form1;
        }

        private void listaDeChoferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la lista de choferes");
            var formListaChoferes = new FrmListaChofer();
            formListaChoferes.ShowDialog();

        }

        private void nuevoChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la creacion de choferes");
            var frmCargarChofer = new FrmCargarChofer();
            frmCargarChofer.ShowDialog();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la creacion de usuarios");
            var frmCargarUsuario = new FrmCrearUsuario();
            frmCargarUsuario.ShowDialog();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la modificacion de usuarios");
            var frmListaUsuario = new FrmListaUsuarios();
            frmListaUsuario.ShowDialog();
        }

        private void listaVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la lista de vehiculos");
            var formLista = new FrmLista();

            formLista.ShowDialog();
        }

        private void nuevoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Abrio la creacion de vehiculos");
            var formCargarV = new FrmCargarV();
            formCargarV.ShowDialog();
        }

        /// <summary>
        /// Configura los labels segun si el Usuario es administrador o no
        /// </summary>
        private void organizarFormulario()
        {

            txt_usuario.Text = "Nombre: " + AdmUsuarios.UsuarioActivo!.Nombre;
            if (AdmUsuarios.UsuarioActivo.Administrador)
            {
                boton_ext_log.Visible = true;
                administrarUsuariosToolStripMenuItem.Enabled = true;
                nuevoChoferToolStripMenuItem.Enabled = true;
                nuevoVehiculoToolStripMenuItem.Enabled = true;
                txt_tipoUsuario.Text = "Tipo de usuario: Administrador";
            }
            else
            {

                boton_ext_log.Visible = false;
                administrarUsuariosToolStripMenuItem.Enabled = false;
                nuevoChoferToolStripMenuItem.Enabled = false;
                nuevoVehiculoToolStripMenuItem.Enabled = false;
                txt_tipoUsuario.Text = "Tipo de usuario: Normal";
            }
            if (!_botonActivo)
            {
                HacerElementosVisibles(false);
            }

        }

        /// <summary>
        /// Agrega las patentes a un combobox
        /// </summary>
        private void cargarPatentes()
        {
            var admVehiculos = new AdmVehiculos();
            var vehiculos = admVehiculos.TraerLista();
            foreach (var vehiculo in vehiculos)
            {
                comboBox_busqueda.Items.Add(vehiculo.Dominio);
            }
        }

        /// <summary>
        /// Agrega los choferes que no estan activos a un combobox
        /// </summary>
        private void cargarChoferesNoActivos()
        {
            var admChoferes = new AdmChoferes();
            var choferes = admChoferes.TraerLista();

            foreach (var chofer in choferes)
            {
                if (!chofer.Activo)
                {
                    comboBox_dniChofer.Items.Add(chofer.DNI);
                }
            }
        }

        /// <summary>
        /// Agrega los choferes que estan activos a un combobox
        /// </summary>
        private void cargarChoferesActivos()
        {
            var admChoferes = new AdmChoferes();
            var choferes = admChoferes.TraerLista();

            foreach (var chofer in choferes)
            {
                if (chofer.Activo)
                {
                    comboBox_dniChofer.Items.Add(chofer.DNI);
                }
            }
        }

        /// <summary>
        /// Actualiza el textbox de choferes segun el dni del Combobox
        /// </summary>
        private void actualizarNombres()
        {
            var admChoferes = new AdmChoferes();
            var choferes = admChoferes.TraerLista();
            foreach (var chofer in choferes)
            {
                if (comboBox_dniChofer.Text == chofer.DNI.ToString())
                {
                    textBox_nombreChofer.Text = chofer.Presentarse();
                }
            }
        }

        /// <summary>
        /// Muestra o esconde elementos como labels, combobox y textbox
        /// </summary>
        /// <param name="booliano"></param>
        private void HacerElementosVisibles(bool booliano)
        {
            if (booliano)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox_dominio.Visible = true;
                textBox_kilometros.Visible = true;
                textBox_marca.Visible = true;
                textBox_modelo.Visible = true;
                textBox_tipo.Visible = true;
                textBox_nombreChofer.Visible = true;
                comboBox_dniChofer.Visible = true;
                textBox_horarioSalida.Visible = true;
                boton_comenzar.Visible = true;
                boton_terminar.Visible = true;
            }
            if (!booliano)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox_dominio.Visible = false;
                textBox_kilometros.Visible = false;
                textBox_marca.Visible = false;
                textBox_modelo.Visible = false;
                textBox_tipo.Visible = false;
                textBox_nombreChofer.Visible = false;
                comboBox_dniChofer.Visible = false;
                textBox_horarioSalida.Visible = false;
                boton_comenzar.Visible = false;
                boton_terminar.Visible = false;
            }

            var admVehiculos = new AdmVehiculos();
            var vehiculos = admVehiculos.TraerLista();
            foreach (var vehiculo in vehiculos)
            {
                if (!vehiculo.Activo)
                {
                    boton_comenzar.Enabled = true;
                    boton_terminar.Enabled = false;
                }
                if (vehiculo.Activo)
                {
                    boton_comenzar.Enabled = false;
                    boton_terminar.Enabled = true;
                }
                break;
            }
        }

        /// <summary>
        /// Muesta y actualiza elementos como labels, combobox y textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_busqueda_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Busco un camion");

            _botonActivo = true;
            var admVehiculos = new AdmVehiculos();
            var vehiculos = admVehiculos.TraerLista();
            comboBox_dniChofer.Items.Clear();
            foreach (var vehiculo in vehiculos)
            {
                if (!vehiculo.Activo)
                {
                    if (comboBox_busqueda.Text == vehiculo.Dominio)
                    {
                        HacerElementosVisibles(true);

                        textBox_dominio.Text = vehiculo.Dominio;
                        textBox_kilometros.Text = vehiculo.Kilometros.ToString();
                        textBox_marca.Text = vehiculo.Marca;
                        textBox_modelo.Text = vehiculo.Modelo;
                        textBox_tipo.Text = vehiculo.Tipo;
                        comboBox_dniChofer.SelectedIndex = -1;
                        textBox_nombreChofer.Text = "";
                        textBox_horarioSalida.Text = "";
                        cargarChoferesNoActivos();
                        boton_comenzar.Enabled = true;
                        boton_terminar.Enabled = false;

                    }
                }
                if (vehiculo.Activo)
                {
                    if (comboBox_busqueda.Text == vehiculo.Dominio)
                    {
                        HacerElementosVisibles(true);
                        textBox_dominio.Text = vehiculo.Dominio;
                        textBox_kilometros.Text = vehiculo.Kilometros.ToString();
                        textBox_marca.Text = vehiculo.Marca;
                        textBox_modelo.Text = vehiculo.Modelo;
                        textBox_tipo.Text = vehiculo.Tipo;
                        cargarChoferesActivos();
                        comboBox_dniChofer.SelectedIndex = BuscarEnElComboBox(comboBox_dniChofer, vehiculo.PersonaAsignada.DNI.ToString());
                        textBox_nombreChofer.Text = vehiculo.PersonaAsignada.Presentarse();
                        textBox_horarioSalida.Text = vehiculo.HorarioSalida;
                        boton_comenzar.Enabled = false;
                        boton_terminar.Enabled = true;
                    }
                }
            }
        }


        /// <summary>
        /// Busca el texto pasado por parametro en un combobox, retorna la posicion
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="textoBuscado"></param>
        /// <returns></returns>
        private int BuscarEnElComboBox(System.Windows.Forms.ComboBox comboBox, string textoBuscado)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                string valorComboBox = comboBox.GetItemText(comboBox.Items[i]);

                if (valorComboBox == textoBuscado)
                {
                    return i;
                }
            }

            return -1;
        }

        private void comboBox_dniChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarNombres();
        }

        private void boton_comenzar_Click(object sender, EventArgs e)
        {


            try
            {
                var admLog = new Log();
                admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Comenzo un viaje");

                textBox_horarioSalida.Text = Horario.HorarioActual();
                var choferes = new AdmChoferes();
                var vehiculos = new AdmVehiculos();
                Persona chofer = choferes.EncontrarChofer(comboBox_dniChofer.Text);
                Vehiculo vehiculo = vehiculos.EncontrarVehiculo(comboBox_busqueda.Text);
                vehiculos.CargarSalidaVehiculo(vehiculo.Dominio, chofer, textBox_horarioSalida.Text);
                choferes.HacerActivoChofer(chofer);
                MessageBox.Show($"Horario de salida: {textBox_horarioSalida.Text}");
                HacerElementosVisibles(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void boton_terminar_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Termino un viaje");
            var choferes = new AdmChoferes();
            var vehiculos = new AdmVehiculos();
            Persona chofer = choferes.EncontrarChofer(comboBox_dniChofer.Text);
            Vehiculo vehiculo = vehiculos.EncontrarVehiculo(comboBox_busqueda.Text);
            var km = new FrmCargarKilometros(vehiculo);
            km.ShowDialog();
            var nuevosKm = km.Kilometros;
            choferes.DesactivarChofer(chofer);
            vehiculos.CargarEntradaVehiculo(vehiculo.Dominio, nuevosKm);
            var horarioEntrada = Horario.HorarioActual();
            AdmBitacora.CargarVehiculo(vehiculo, horarioEntrada, nuevosKm);
            HacerElementosVisibles(false);
        }

        private void button_cerrarSesion_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Cerro sesion");
            _form1.Show();
            Close();

        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            organizarFormulario();
            cargarPatentes();
            _form1.Hide();
        }

        private void boton_ext_pdf_Click(object sender, EventArgs e)
        {
            var admLog = new Log();
            admLog.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto la lista de viajes a PDF");

            var viajes = new FrmViajes();
            viajes.ShowDialog();
            var listaElementos = AdmBitacora.TraerLista(viajes.Viajes);
            Informes<ElementosDeBitacora>.GuardarPDF(listaElementos);
        }

        private void boton_ext_log_Click(object sender, EventArgs e)
        {
            var log = new Log();
            log.AdmLog_MetodoActivado(AdmUsuarios.UsuarioActivo.Nombre, DateTime.Now.ToString(), "Exporto la lista de logs a PDF");
            var admLogs = new AdmLogs();
            Informes<LogParaPdf>.GuardarLogsPDF(admLogs.DevolverLogs());
        }
    }
}