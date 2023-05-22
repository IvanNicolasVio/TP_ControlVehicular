namespace FrmPrincipal
{
    partial class FrmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearUsuario));
            boton_crear = new Button();
            boton_cancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_nombreUsuario = new TextBox();
            textBox_contrasenia = new TextBox();
            comboBox_administrador = new ComboBox();
            SuspendLayout();
            // 
            // boton_crear
            // 
            boton_crear.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_crear.Location = new Point(35, 297);
            boton_crear.Name = "boton_crear";
            boton_crear.Size = new Size(86, 37);
            boton_crear.TabIndex = 0;
            boton_crear.Text = "CREAR";
            boton_crear.UseVisualStyleBackColor = true;
            boton_crear.Click += boton_crear_Click;
            // 
            // boton_cancelar
            // 
            boton_cancelar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_cancelar.Location = new Point(144, 297);
            boton_cancelar.Name = "boton_cancelar";
            boton_cancelar.Size = new Size(86, 37);
            boton_cancelar.TabIndex = 1;
            boton_cancelar.Text = "CANCELAR";
            boton_cancelar.UseVisualStyleBackColor = true;
            boton_cancelar.Click += boton_cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 106);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 194);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 4;
            label3.Text = "¿ADMINISTRADOR?";
            // 
            // textBox_nombreUsuario
            // 
            textBox_nombreUsuario.Location = new Point(35, 61);
            textBox_nombreUsuario.Name = "textBox_nombreUsuario";
            textBox_nombreUsuario.Size = new Size(195, 23);
            textBox_nombreUsuario.TabIndex = 5;
            // 
            // textBox_contrasenia
            // 
            textBox_contrasenia.Location = new Point(35, 142);
            textBox_contrasenia.Name = "textBox_contrasenia";
            textBox_contrasenia.Size = new Size(195, 23);
            textBox_contrasenia.TabIndex = 6;
            // 
            // comboBox_administrador
            // 
            comboBox_administrador.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_administrador.FormattingEnabled = true;
            comboBox_administrador.Items.AddRange(new object[] { "SI", "NO" });
            comboBox_administrador.Location = new Point(35, 232);
            comboBox_administrador.Name = "comboBox_administrador";
            comboBox_administrador.Size = new Size(195, 23);
            comboBox_administrador.TabIndex = 7;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(267, 381);
            Controls.Add(comboBox_administrador);
            Controls.Add(textBox_contrasenia);
            Controls.Add(textBox_nombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boton_cancelar);
            Controls.Add(boton_crear);
            MaximizeBox = false;
            Name = "FrmCrearUsuario";
            ShowIcon = false;
            Text = "Crear usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_crear;
        private Button boton_cancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_nombreUsuario;
        private TextBox textBox_contrasenia;
        private ComboBox comboBox_administrador;
    }
}