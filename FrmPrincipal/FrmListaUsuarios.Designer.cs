namespace FrmPrincipal
{
    partial class FrmListaUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaUsuarios));
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            boton_borrar = new Button();
            button1 = new Button();
            textBox_usuario = new TextBox();
            textBox_contrasenia = new TextBox();
            boton_editar = new Button();
            boton_salir = new Button();
            label_usuario = new Label();
            label2 = new Label();
            label_administrador = new Label();
            comboBox_administrador = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.Controls.Add(boton_borrar);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(textBox_usuario);
            splitContainer1.Panel2.Controls.Add(textBox_contrasenia);
            splitContainer1.Panel2.Controls.Add(boton_editar);
            splitContainer1.Panel2.Controls.Add(boton_salir);
            splitContainer1.Panel2.Controls.Add(label_usuario);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label_administrador);
            splitContainer1.Panel2.Controls.Add(comboBox_administrador);
            splitContainer1.Size = new Size(409, 546);
            splitContainer1.SplitterDistance = 134;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(134, 546);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // boton_borrar
            // 
            boton_borrar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_borrar.Location = new Point(85, 447);
            boton_borrar.Name = "boton_borrar";
            boton_borrar.Size = new Size(85, 35);
            boton_borrar.TabIndex = 9;
            boton_borrar.Text = "BORRAR";
            boton_borrar.UseVisualStyleBackColor = true;
            boton_borrar.Click += boton_borrar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(181, 12);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 8;
            button1.Text = "MOSTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_usuario
            // 
            textBox_usuario.Location = new Point(28, 90);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(201, 23);
            textBox_usuario.TabIndex = 7;
            // 
            // textBox_contrasenia
            // 
            textBox_contrasenia.Location = new Point(28, 241);
            textBox_contrasenia.Name = "textBox_contrasenia";
            textBox_contrasenia.Size = new Size(201, 23);
            textBox_contrasenia.TabIndex = 6;
            // 
            // boton_editar
            // 
            boton_editar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_editar.Location = new Point(28, 499);
            boton_editar.Name = "boton_editar";
            boton_editar.Size = new Size(85, 35);
            boton_editar.TabIndex = 5;
            boton_editar.Text = "EDITAR";
            boton_editar.UseVisualStyleBackColor = true;
            boton_editar.Click += boton_editar_Click;
            // 
            // boton_salir
            // 
            boton_salir.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_salir.Location = new Point(144, 499);
            boton_salir.Name = "boton_salir";
            boton_salir.Size = new Size(85, 35);
            boton_salir.TabIndex = 4;
            boton_salir.Text = "SALIR";
            boton_salir.UseVisualStyleBackColor = true;
            boton_salir.Click += boton_salir_Click;
            // 
            // label_usuario
            // 
            label_usuario.AutoSize = true;
            label_usuario.BackColor = Color.Transparent;
            label_usuario.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_usuario.Location = new Point(28, 41);
            label_usuario.Name = "label_usuario";
            label_usuario.Size = new Size(74, 23);
            label_usuario.TabIndex = 3;
            label_usuario.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 193);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 2;
            label2.Text = "CONTRASEÑA";
            // 
            // label_administrador
            // 
            label_administrador.AutoSize = true;
            label_administrador.BackColor = Color.Transparent;
            label_administrador.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_administrador.Location = new Point(28, 346);
            label_administrador.Name = "label_administrador";
            label_administrador.Size = new Size(153, 23);
            label_administrador.TabIndex = 1;
            label_administrador.Text = "¿ADMINISTRADOR?";
            // 
            // comboBox_administrador
            // 
            comboBox_administrador.AutoCompleteCustomSource.AddRange(new string[] { "SI", "NO" });
            comboBox_administrador.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_administrador.FormattingEnabled = true;
            comboBox_administrador.Items.AddRange(new object[] { "SI", "NO" });
            comboBox_administrador.Location = new Point(28, 392);
            comboBox_administrador.Name = "comboBox_administrador";
            comboBox_administrador.Size = new Size(201, 23);
            comboBox_administrador.TabIndex = 0;
            // 
            // FrmListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(409, 546);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "FrmListaUsuarios";
            ShowIcon = false;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private TextBox textBox_usuario;
        private TextBox textBox_contrasenia;
        private Button boton_editar;
        private Button boton_salir;
        private Label label_usuario;
        private Label label2;
        private Label label_administrador;
        private ComboBox comboBox_administrador;
        private Button button1;
        private Button boton_borrar;
    }
}