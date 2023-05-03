namespace FrmPrincipal
{
    partial class FrmContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            listaVehiculosToolStripMenuItem = new ToolStripMenuItem();
            nuevoVehiculoToolStripMenuItem = new ToolStripMenuItem();
            boton_busqueda = new Button();
            txt_tipoUsuario = new Label();
            txtBox_busqueda = new TextBox();
            comboBox_opciones = new ComboBox();
            txt_usuario = new Label();
            choferesToolStripMenuItem = new ToolStripMenuItem();
            listaDeChoferesToolStripMenuItem = new ToolStripMenuItem();
            nuevoChoferToolStripMenuItem = new ToolStripMenuItem();
            administrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, choferesToolStripMenuItem, administrarUsuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaVehiculosToolStripMenuItem, nuevoVehiculoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(69, 20);
            menuToolStripMenuItem.Text = "Vehiculos";
            // 
            // listaVehiculosToolStripMenuItem
            // 
            listaVehiculosToolStripMenuItem.Name = "listaVehiculosToolStripMenuItem";
            listaVehiculosToolStripMenuItem.Size = new Size(180, 22);
            listaVehiculosToolStripMenuItem.Text = "Lista de vehiculos";
            listaVehiculosToolStripMenuItem.Click += listaVehiculosToolStripMenuItem_Click;
            // 
            // nuevoVehiculoToolStripMenuItem
            // 
            nuevoVehiculoToolStripMenuItem.Name = "nuevoVehiculoToolStripMenuItem";
            nuevoVehiculoToolStripMenuItem.Size = new Size(180, 22);
            nuevoVehiculoToolStripMenuItem.Text = "Nuevo vehiculo";
            nuevoVehiculoToolStripMenuItem.Click += nuevoVehiculoToolStripMenuItem_Click;
            // 
            // boton_busqueda
            // 
            boton_busqueda.Location = new Point(12, 87);
            boton_busqueda.Name = "boton_busqueda";
            boton_busqueda.Size = new Size(75, 24);
            boton_busqueda.TabIndex = 5;
            boton_busqueda.Text = "BUSCAR";
            boton_busqueda.UseVisualStyleBackColor = true;
            // 
            // txt_tipoUsuario
            // 
            txt_tipoUsuario.AutoSize = true;
            txt_tipoUsuario.Location = new Point(12, 426);
            txt_tipoUsuario.Name = "txt_tipoUsuario";
            txt_tipoUsuario.Size = new Size(94, 15);
            txt_tipoUsuario.TabIndex = 6;
            txt_tipoUsuario.Text = "Tipo de usuario: ";
            // 
            // txtBox_busqueda
            // 
            txtBox_busqueda.Location = new Point(12, 58);
            txtBox_busqueda.Name = "txtBox_busqueda";
            txtBox_busqueda.PlaceholderText = "Buscar por patente";
            txtBox_busqueda.Size = new Size(263, 23);
            txtBox_busqueda.TabIndex = 8;
            // 
            // comboBox_opciones
            // 
            comboBox_opciones.FormattingEnabled = true;
            comboBox_opciones.Items.AddRange(new object[] { "Vehiculo por patente", "Persona por legajo" });
            comboBox_opciones.Location = new Point(93, 87);
            comboBox_opciones.Name = "comboBox_opciones";
            comboBox_opciones.Size = new Size(184, 23);
            comboBox_opciones.TabIndex = 9;
            // 
            // txt_usuario
            // 
            txt_usuario.AutoSize = true;
            txt_usuario.Location = new Point(12, 402);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(53, 15);
            txt_usuario.TabIndex = 11;
            txt_usuario.Text = "Usuario: ";
            // 
            // choferesToolStripMenuItem
            // 
            choferesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeChoferesToolStripMenuItem, nuevoChoferToolStripMenuItem });
            choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            choferesToolStripMenuItem.Size = new Size(66, 20);
            choferesToolStripMenuItem.Text = "Choferes";
            // 
            // listaDeChoferesToolStripMenuItem
            // 
            listaDeChoferesToolStripMenuItem.Name = "listaDeChoferesToolStripMenuItem";
            listaDeChoferesToolStripMenuItem.Size = new Size(180, 22);
            listaDeChoferesToolStripMenuItem.Text = "Lista de choferes";
            // 
            // nuevoChoferToolStripMenuItem
            // 
            nuevoChoferToolStripMenuItem.Name = "nuevoChoferToolStripMenuItem";
            nuevoChoferToolStripMenuItem.Size = new Size(180, 22);
            nuevoChoferToolStripMenuItem.Text = "Nuevo chofer";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem });
            administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            administrarUsuariosToolStripMenuItem.Size = new Size(128, 20);
            administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(180, 22);
            crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            // 
            // FrmContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_usuario);
            Controls.Add(comboBox_opciones);
            Controls.Add(txtBox_busqueda);
            Controls.Add(txt_tipoUsuario);
            Controls.Add(boton_busqueda);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmContenedor";
            Text = "Control Vehicular";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem listaVehiculosToolStripMenuItem;
        private ToolStripMenuItem nuevoVehiculoToolStripMenuItem;
        private Button boton_busqueda;
        private Label txt_tipoUsuario;
        private TextBox txtBox_busqueda;
        private ComboBox comboBox_opciones;
        private Label txt_usuario;
        private ToolStripMenuItem choferesToolStripMenuItem;
        private ToolStripMenuItem listaDeChoferesToolStripMenuItem;
        private ToolStripMenuItem nuevoChoferToolStripMenuItem;
        private ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
    }
}