﻿namespace FrmPrincipal
{
    partial class FrmCargarV
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
            button1 = new Button();
            txtBox_patente = new TextBox();
            txtBox_tipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBox_kilometros = new TextBox();
            txtBox_modelo = new TextBox();
            txtBox_marca = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 358);
            button1.Name = "button1";
            button1.Size = new Size(93, 30);
            button1.TabIndex = 0;
            button1.Text = "CARGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBox_patente
            // 
            txtBox_patente.Location = new Point(42, 47);
            txtBox_patente.Name = "txtBox_patente";
            txtBox_patente.PlaceholderText = "Ingrese el dominio o patente";
            txtBox_patente.Size = new Size(272, 23);
            txtBox_patente.TabIndex = 1;
            // 
            // txtBox_tipo
            // 
            txtBox_tipo.Location = new Point(42, 101);
            txtBox_tipo.Name = "txtBox_tipo";
            txtBox_tipo.PlaceholderText = "Ingrese el tipo de vehiculo. Ej Camion";
            txtBox_tipo.Size = new Size(272, 23);
            txtBox_tipo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 83);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "TIPO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "DOMINIO";
            // 
            // txtBox_kilometros
            // 
            txtBox_kilometros.Location = new Point(42, 266);
            txtBox_kilometros.Name = "txtBox_kilometros";
            txtBox_kilometros.PlaceholderText = "Ingrese los kilometros actuales del vehiculo";
            txtBox_kilometros.Size = new Size(272, 23);
            txtBox_kilometros.TabIndex = 5;
            // 
            // txtBox_modelo
            // 
            txtBox_modelo.Location = new Point(42, 214);
            txtBox_modelo.Name = "txtBox_modelo";
            txtBox_modelo.PlaceholderText = "Ingrese el modelo del vehiculo. Ej Fiesta";
            txtBox_modelo.Size = new Size(272, 23);
            txtBox_modelo.TabIndex = 6;
            // 
            // txtBox_marca
            // 
            txtBox_marca.Location = new Point(42, 162);
            txtBox_marca.Name = "txtBox_marca";
            txtBox_marca.PlaceholderText = "Ingrese la marca del vehiculo. Ej Ford";
            txtBox_marca.Size = new Size(272, 23);
            txtBox_marca.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 144);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "MARCA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 196);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "MODELO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 248);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 10;
            label5.Text = "KILOMETROS";
            // 
            // button2
            // 
            button2.Location = new Point(221, 358);
            button2.Name = "button2";
            button2.Size = new Size(93, 30);
            button2.TabIndex = 11;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmCargarV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(386, 440);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBox_marca);
            Controls.Add(txtBox_modelo);
            Controls.Add(txtBox_kilometros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_tipo);
            Controls.Add(txtBox_patente);
            Controls.Add(button1);
            Name = "FrmCargarV";
            Text = "FrmCargarV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBox_patente;
        private TextBox txtBox_tipo;
        private Label label1;
        private Label label2;
        private TextBox txtBox_kilometros;
        private TextBox txtBox_modelo;
        private TextBox txtBox_marca;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}