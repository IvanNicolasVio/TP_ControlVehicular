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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContenedor));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            listaVehiculosToolStripMenuItem = new ToolStripMenuItem();
            nuevoVehiculoToolStripMenuItem = new ToolStripMenuItem();
            choferesToolStripMenuItem = new ToolStripMenuItem();
            listaDeChoferesToolStripMenuItem = new ToolStripMenuItem();
            nuevoChoferToolStripMenuItem = new ToolStripMenuItem();
            administrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            boton_busqueda = new Button();
            txt_tipoUsuario = new Label();
            txt_usuario = new Label();
            comboBox_busqueda = new ComboBox();
            textBox_dominio = new TextBox();
            textBox_kilometros = new TextBox();
            textBox_marca = new TextBox();
            textBox_modelo = new TextBox();
            textBox_tipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_nombreChofer = new TextBox();
            boton_comenzar = new Button();
            label8 = new Label();
            textBox_horarioSalida = new TextBox();
            boton_terminar = new Button();
            comboBox_dniChofer = new ComboBox();
            button_cerrarSesion = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, choferesToolStripMenuItem, administrarUsuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("menuToolStripMenuItem.BackgroundImage");
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaVehiculosToolStripMenuItem, nuevoVehiculoToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(84, 24);
            menuToolStripMenuItem.Text = "Vehiculos";
            // 
            // listaVehiculosToolStripMenuItem
            // 
            listaVehiculosToolStripMenuItem.Name = "listaVehiculosToolStripMenuItem";
            listaVehiculosToolStripMenuItem.Size = new Size(195, 24);
            listaVehiculosToolStripMenuItem.Text = "Lista de vehiculos";
            listaVehiculosToolStripMenuItem.Click += listaVehiculosToolStripMenuItem_Click;
            // 
            // nuevoVehiculoToolStripMenuItem
            // 
            nuevoVehiculoToolStripMenuItem.Name = "nuevoVehiculoToolStripMenuItem";
            nuevoVehiculoToolStripMenuItem.Size = new Size(195, 24);
            nuevoVehiculoToolStripMenuItem.Text = "Nuevo vehiculo";
            nuevoVehiculoToolStripMenuItem.Click += nuevoVehiculoToolStripMenuItem_Click;
            // 
            // choferesToolStripMenuItem
            // 
            choferesToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("choferesToolStripMenuItem.BackgroundImage");
            choferesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeChoferesToolStripMenuItem, nuevoChoferToolStripMenuItem });
            choferesToolStripMenuItem.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            choferesToolStripMenuItem.Size = new Size(81, 24);
            choferesToolStripMenuItem.Text = "Choferes";
            // 
            // listaDeChoferesToolStripMenuItem
            // 
            listaDeChoferesToolStripMenuItem.Name = "listaDeChoferesToolStripMenuItem";
            listaDeChoferesToolStripMenuItem.Size = new Size(190, 24);
            listaDeChoferesToolStripMenuItem.Text = "Lista de choferes";
            listaDeChoferesToolStripMenuItem.Click += listaDeChoferesToolStripMenuItem_Click;
            // 
            // nuevoChoferToolStripMenuItem
            // 
            nuevoChoferToolStripMenuItem.Name = "nuevoChoferToolStripMenuItem";
            nuevoChoferToolStripMenuItem.Size = new Size(190, 24);
            nuevoChoferToolStripMenuItem.Text = "Nuevo chofer";
            nuevoChoferToolStripMenuItem.Click += nuevoChoferToolStripMenuItem_Click;
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            administrarUsuariosToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("administrarUsuariosToolStripMenuItem.BackgroundImage");
            administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem });
            administrarUsuariosToolStripMenuItem.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            administrarUsuariosToolStripMenuItem.Size = new Size(158, 24);
            administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(193, 24);
            crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            crearUsuarioToolStripMenuItem.Click += crearUsuarioToolStripMenuItem_Click;
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new Size(193, 24);
            modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            modificarUsuarioToolStripMenuItem.Click += modificarUsuarioToolStripMenuItem_Click;
            // 
            // boton_busqueda
            // 
            boton_busqueda.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_busqueda.Location = new Point(12, 87);
            boton_busqueda.Name = "boton_busqueda";
            boton_busqueda.Size = new Size(263, 33);
            boton_busqueda.TabIndex = 5;
            boton_busqueda.Text = "BUSCAR VEHICULO POR DOMINIO";
            boton_busqueda.UseVisualStyleBackColor = true;
            boton_busqueda.Click += boton_busqueda_Click;
            // 
            // txt_tipoUsuario
            // 
            txt_tipoUsuario.AutoSize = true;
            txt_tipoUsuario.BackColor = Color.Transparent;
            txt_tipoUsuario.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tipoUsuario.Location = new Point(12, 418);
            txt_tipoUsuario.Name = "txt_tipoUsuario";
            txt_tipoUsuario.Size = new Size(138, 23);
            txt_tipoUsuario.TabIndex = 6;
            txt_tipoUsuario.Text = "Tipo de usuario: ";
            // 
            // txt_usuario
            // 
            txt_usuario.AutoSize = true;
            txt_usuario.BackColor = Color.Transparent;
            txt_usuario.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(12, 383);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(78, 23);
            txt_usuario.TabIndex = 11;
            txt_usuario.Text = "Usuario: ";
            // 
            // comboBox_busqueda
            // 
            comboBox_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_busqueda.FormattingEnabled = true;
            comboBox_busqueda.Location = new Point(12, 58);
            comboBox_busqueda.Name = "comboBox_busqueda";
            comboBox_busqueda.Size = new Size(263, 23);
            comboBox_busqueda.TabIndex = 13;
            // 
            // textBox_dominio
            // 
            textBox_dominio.Location = new Point(503, 58);
            textBox_dominio.Name = "textBox_dominio";
            textBox_dominio.ReadOnly = true;
            textBox_dominio.Size = new Size(215, 23);
            textBox_dominio.TabIndex = 15;
            // 
            // textBox_kilometros
            // 
            textBox_kilometros.Location = new Point(503, 87);
            textBox_kilometros.Name = "textBox_kilometros";
            textBox_kilometros.ReadOnly = true;
            textBox_kilometros.Size = new Size(215, 23);
            textBox_kilometros.TabIndex = 16;
            // 
            // textBox_marca
            // 
            textBox_marca.Location = new Point(503, 116);
            textBox_marca.Name = "textBox_marca";
            textBox_marca.ReadOnly = true;
            textBox_marca.Size = new Size(215, 23);
            textBox_marca.TabIndex = 17;
            // 
            // textBox_modelo
            // 
            textBox_modelo.Location = new Point(503, 145);
            textBox_modelo.Name = "textBox_modelo";
            textBox_modelo.ReadOnly = true;
            textBox_modelo.Size = new Size(215, 23);
            textBox_modelo.TabIndex = 18;
            // 
            // textBox_tipo
            // 
            textBox_tipo.Location = new Point(503, 174);
            textBox_tipo.Name = "textBox_tipo";
            textBox_tipo.ReadOnly = true;
            textBox_tipo.Size = new Size(215, 23);
            textBox_tipo.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(420, 58);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 20;
            label1.Text = "DOMINIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(392, 88);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 21;
            label2.Text = "KILOMETROS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(432, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 22;
            label3.Text = "MARCA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(427, 145);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 23;
            label4.Text = "MODELO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(451, 174);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 24;
            label5.Text = "TIPO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(332, 232);
            label6.Name = "label6";
            label6.Size = new Size(163, 23);
            label6.TabIndex = 26;
            label6.Text = "NOMBRE DEL CHOFER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(371, 203);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 27;
            label7.Text = "DNI DEL CHOFER";
            // 
            // textBox_nombreChofer
            // 
            textBox_nombreChofer.Location = new Point(503, 232);
            textBox_nombreChofer.Name = "textBox_nombreChofer";
            textBox_nombreChofer.ReadOnly = true;
            textBox_nombreChofer.Size = new Size(215, 23);
            textBox_nombreChofer.TabIndex = 28;
            // 
            // boton_comenzar
            // 
            boton_comenzar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_comenzar.Location = new Point(503, 313);
            boton_comenzar.Name = "boton_comenzar";
            boton_comenzar.Size = new Size(215, 32);
            boton_comenzar.TabIndex = 31;
            boton_comenzar.Text = "COMENZAR RECORRIDO";
            boton_comenzar.UseVisualStyleBackColor = true;
            boton_comenzar.Click += boton_comenzar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(366, 261);
            label8.Name = "label8";
            label8.Size = new Size(129, 23);
            label8.TabIndex = 32;
            label8.Text = "HORARIO SALIDA";
            // 
            // textBox_horarioSalida
            // 
            textBox_horarioSalida.Location = new Point(503, 261);
            textBox_horarioSalida.Name = "textBox_horarioSalida";
            textBox_horarioSalida.ReadOnly = true;
            textBox_horarioSalida.Size = new Size(215, 23);
            textBox_horarioSalida.TabIndex = 33;
            // 
            // boton_terminar
            // 
            boton_terminar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_terminar.Location = new Point(503, 351);
            boton_terminar.Name = "boton_terminar";
            boton_terminar.Size = new Size(215, 32);
            boton_terminar.TabIndex = 34;
            boton_terminar.Text = "TERMINAR RECORRIDO";
            boton_terminar.UseVisualStyleBackColor = true;
            boton_terminar.Click += boton_terminar_Click;
            // 
            // comboBox_dniChofer
            // 
            comboBox_dniChofer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_dniChofer.FormattingEnabled = true;
            comboBox_dniChofer.Location = new Point(503, 203);
            comboBox_dniChofer.Name = "comboBox_dniChofer";
            comboBox_dniChofer.Size = new Size(215, 23);
            comboBox_dniChofer.TabIndex = 35;
            comboBox_dniChofer.SelectedIndexChanged += comboBox_dniChofer_SelectedIndexChanged;
            // 
            // button_cerrarSesion
            // 
            button_cerrarSesion.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_cerrarSesion.Location = new Point(645, 414);
            button_cerrarSesion.Name = "button_cerrarSesion";
            button_cerrarSesion.Size = new Size(143, 27);
            button_cerrarSesion.TabIndex = 37;
            button_cerrarSesion.Text = "CERRAR SESION";
            button_cerrarSesion.UseVisualStyleBackColor = true;
            button_cerrarSesion.Click += button_cerrarSesion_Click;
            // 
            // FrmContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txt_tipoUsuario);
            Controls.Add(txt_usuario);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(button_cerrarSesion);
            Controls.Add(comboBox_dniChofer);
            Controls.Add(boton_terminar);
            Controls.Add(textBox_horarioSalida);
            Controls.Add(boton_comenzar);
            Controls.Add(textBox_nombreChofer);
            Controls.Add(textBox_tipo);
            Controls.Add(textBox_modelo);
            Controls.Add(textBox_marca);
            Controls.Add(textBox_kilometros);
            Controls.Add(textBox_dominio);
            Controls.Add(comboBox_busqueda);
            Controls.Add(boton_busqueda);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmContenedor";
            ShowIcon = false;
            Text = "Control Vehicular";
            Load += FrmContenedor_Load;
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
        private Label txt_usuario;
        private ToolStripMenuItem choferesToolStripMenuItem;
        private ToolStripMenuItem listaDeChoferesToolStripMenuItem;
        private ToolStripMenuItem nuevoChoferToolStripMenuItem;
        private ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private ComboBox comboBox_busqueda;
        private TextBox textBox_dominio;
        private TextBox textBox_kilometros;
        private TextBox textBox_marca;
        private TextBox textBox_modelo;
        private TextBox textBox_tipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_nombreChofer;
        private Button boton_comenzar;
        private Label label8;
        private TextBox textBox_horarioSalida;
        private Button boton_terminar;
        private ComboBox comboBox_dniChofer;
        private Button button_cerrarSesion;
    }
}