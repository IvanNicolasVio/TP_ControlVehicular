namespace FrmPrincipal
{
    partial class FrmCargarKilometros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarKilometros));
            boton_cargar = new Button();
            textBox_km = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // boton_cargar
            // 
            boton_cargar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boton_cargar.Location = new Point(57, 138);
            boton_cargar.Name = "boton_cargar";
            boton_cargar.Size = new Size(100, 38);
            boton_cargar.TabIndex = 0;
            boton_cargar.Text = "CARGAR";
            boton_cargar.UseVisualStyleBackColor = true;
            boton_cargar.Click += boton_cargar_Click;
            // 
            // textBox_km
            // 
            textBox_km.Location = new Point(57, 81);
            textBox_km.Name = "textBox_km";
            textBox_km.Size = new Size(100, 23);
            textBox_km.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 24);
            label1.Name = "label1";
            label1.Size = new Size(214, 23);
            label1.TabIndex = 2;
            label1.Text = "INGRESE LOS KMS ACTUALES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1, 58);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Km anteriores: ";
            // 
            // FrmCargarKilometros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(212, 188);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_km);
            Controls.Add(boton_cargar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCargarKilometros";
            ShowIcon = false;
            Text = "Cargar km";
            Load += FrmCargarKilometros_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_cargar;
        private TextBox textBox_km;
        private Label label1;
        private Label label2;
    }
}