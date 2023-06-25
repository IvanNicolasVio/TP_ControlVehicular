namespace Biblioteca_de_Formularios
{
    partial class FrmViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViajes));
            boton_aceptar = new Button();
            boton_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label_modificable = new Label();
            SuspendLayout();
            // 
            // boton_aceptar
            // 
            boton_aceptar.BackgroundImageLayout = ImageLayout.None;
            boton_aceptar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_aceptar.Location = new Point(12, 141);
            boton_aceptar.Name = "boton_aceptar";
            boton_aceptar.Size = new Size(75, 28);
            boton_aceptar.TabIndex = 0;
            boton_aceptar.Text = "ACEPTAR";
            boton_aceptar.UseVisualStyleBackColor = true;
            boton_aceptar.Click += boton_aceptar_Click;
            // 
            // boton_salir
            // 
            boton_salir.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_salir.Location = new Point(132, 141);
            boton_salir.Name = "boton_salir";
            boton_salir.Size = new Size(75, 28);
            boton_salir.TabIndex = 1;
            boton_salir.Text = "SALIR";
            boton_salir.UseVisualStyleBackColor = true;
            boton_salir.Click += boton_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = "CANTIDAD DE VIAJES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 3;
            label2.Text = "CANTIDAD DE VIAJES A TRAER:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label_modificable
            // 
            label_modificable.AutoSize = true;
            label_modificable.BackColor = Color.Transparent;
            label_modificable.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_modificable.Location = new Point(20, 38);
            label_modificable.Name = "label_modificable";
            label_modificable.Size = new Size(0, 20);
            label_modificable.TabIndex = 5;
            // 
            // FrmViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(219, 193);
            Controls.Add(label_modificable);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boton_salir);
            Controls.Add(boton_aceptar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmViajes";
            ShowIcon = false;
            Load += FrmViajes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_aceptar;
        private Button boton_salir;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label_modificable;
    }
}