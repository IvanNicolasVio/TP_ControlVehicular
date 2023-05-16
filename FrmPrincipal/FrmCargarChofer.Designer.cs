namespace FrmPrincipal
{
    partial class FrmCargarChofer
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
            boton_cargar = new Button();
            boton_cancelar = new Button();
            label_nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_nombre = new TextBox();
            textBox_apellido = new TextBox();
            textBox_dni = new TextBox();
            textBox_edad = new TextBox();
            SuspendLayout();
            // 
            // boton_cargar
            // 
            boton_cargar.Location = new Point(33, 365);
            boton_cargar.Name = "boton_cargar";
            boton_cargar.Size = new Size(93, 34);
            boton_cargar.TabIndex = 0;
            boton_cargar.Text = "CARGAR";
            boton_cargar.UseVisualStyleBackColor = true;
            boton_cargar.Click += boton_cargar_Click;
            // 
            // boton_cancelar
            // 
            boton_cancelar.Location = new Point(169, 365);
            boton_cancelar.Name = "boton_cancelar";
            boton_cancelar.Size = new Size(93, 34);
            boton_cancelar.TabIndex = 1;
            boton_cancelar.Text = "CANCELAR";
            boton_cancelar.UseVisualStyleBackColor = true;
            boton_cancelar.Click += boton_cancelar_Click;
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Location = new Point(33, 18);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(56, 15);
            label_nombre.TabIndex = 2;
            label_nombre.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 161);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 245);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "EDAD";
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(33, 47);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.PlaceholderText = "Ingrese un nombre";
            textBox_nombre.Size = new Size(229, 23);
            textBox_nombre.TabIndex = 6;
            // 
            // textBox_apellido
            // 
            textBox_apellido.Location = new Point(33, 113);
            textBox_apellido.Name = "textBox_apellido";
            textBox_apellido.PlaceholderText = "Ingrese un apellido";
            textBox_apellido.Size = new Size(229, 23);
            textBox_apellido.TabIndex = 7;
            // 
            // textBox_dni
            // 
            textBox_dni.Location = new Point(33, 196);
            textBox_dni.Name = "textBox_dni";
            textBox_dni.PlaceholderText = "Ingrese un DNI sin puntos";
            textBox_dni.Size = new Size(229, 23);
            textBox_dni.TabIndex = 8;
            // 
            // textBox_edad
            // 
            textBox_edad.Location = new Point(33, 278);
            textBox_edad.Name = "textBox_edad";
            textBox_edad.PlaceholderText = "Ingrese la edad";
            textBox_edad.Size = new Size(229, 23);
            textBox_edad.TabIndex = 9;
            // 
            // FrmCargarChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 443);
            Controls.Add(textBox_edad);
            Controls.Add(textBox_dni);
            Controls.Add(textBox_apellido);
            Controls.Add(textBox_nombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_nombre);
            Controls.Add(boton_cancelar);
            Controls.Add(boton_cargar);
            Name = "FrmCargarChofer";
            Text = "FrmCargarChofer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_cargar;
        private Button boton_cancelar;
        private Label label_nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_nombre;
        private TextBox textBox_apellido;
        private TextBox textBox_dni;
        private TextBox textBox_edad;
    }
}