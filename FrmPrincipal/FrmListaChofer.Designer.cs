﻿namespace FrmPrincipal
{
    partial class FrmListaChofer
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
            dataGridView1 = new DataGridView();
            boton_mostrar = new Button();
            boton_editar = new Button();
            boton_borrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 388);
            dataGridView1.TabIndex = 0;
            // 
            // boton_mostrar
            // 
            boton_mostrar.Location = new Point(12, 12);
            boton_mostrar.Name = "boton_mostrar";
            boton_mostrar.Size = new Size(96, 32);
            boton_mostrar.TabIndex = 1;
            boton_mostrar.Text = "MOSTRAR";
            boton_mostrar.UseVisualStyleBackColor = true;
            boton_mostrar.Click += boton_mostrar_Click;
            // 
            // boton_editar
            // 
            boton_editar.Location = new Point(135, 12);
            boton_editar.Name = "boton_editar";
            boton_editar.Size = new Size(146, 32);
            boton_editar.TabIndex = 2;
            boton_editar.Text = "GUARDAR CAMBIOS";
            boton_editar.UseVisualStyleBackColor = true;
            boton_editar.Click += boton_editar_Click;
            // 
            // boton_borrar
            // 
            boton_borrar.Location = new Point(306, 12);
            boton_borrar.Name = "boton_borrar";
            boton_borrar.Size = new Size(96, 32);
            boton_borrar.TabIndex = 3;
            boton_borrar.Text = "ELIMINAR FILA";
            boton_borrar.UseVisualStyleBackColor = true;
            boton_borrar.Click += boton_eliminar_Click;
            // 
            // FrmListaChofer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton_borrar);
            Controls.Add(boton_editar);
            Controls.Add(boton_mostrar);
            Controls.Add(dataGridView1);
            Name = "FrmListaChofer";
            Text = "FrmListaChofer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button boton_mostrar;
        private Button boton_editar;
        private Button boton_borrar;
    }
}