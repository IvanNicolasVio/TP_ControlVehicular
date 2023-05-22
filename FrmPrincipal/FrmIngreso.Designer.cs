namespace FrmPrincipal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBox_usuario = new TextBox();
            txtBox_contrasenia = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 273);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 0;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(147, 274);
            button2.Name = "button2";
            button2.Size = new Size(87, 31);
            button2.TabIndex = 1;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 45);
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
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // txtBox_usuario
            // 
            txtBox_usuario.Location = new Point(12, 87);
            txtBox_usuario.Name = "txtBox_usuario";
            txtBox_usuario.PlaceholderText = "Ingrese su usuario";
            txtBox_usuario.Size = new Size(222, 23);
            txtBox_usuario.TabIndex = 4;
            // 
            // txtBox_contrasenia
            // 
            txtBox_contrasenia.Location = new Point(12, 198);
            txtBox_contrasenia.Name = "txtBox_contrasenia";
            txtBox_contrasenia.PasswordChar = '*';
            txtBox_contrasenia.PlaceholderText = "Ingrese su contraseña";
            txtBox_contrasenia.Size = new Size(222, 23);
            txtBox_contrasenia.TabIndex = 5;
            txtBox_contrasenia.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(257, 354);
            Controls.Add(txtBox_contrasenia);
            Controls.Add(txtBox_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtBox_usuario;
        private TextBox txtBox_contrasenia;
    }
}