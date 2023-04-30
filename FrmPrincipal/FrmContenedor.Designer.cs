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
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
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
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // listaVehiculosToolStripMenuItem
            // 
            listaVehiculosToolStripMenuItem.Name = "listaVehiculosToolStripMenuItem";
            listaVehiculosToolStripMenuItem.Size = new Size(180, 22);
            listaVehiculosToolStripMenuItem.Text = "Lista Vehiculos";
            listaVehiculosToolStripMenuItem.Click += listaVehiculosToolStripMenuItem_Click;
            // 
            // nuevoVehiculoToolStripMenuItem
            // 
            nuevoVehiculoToolStripMenuItem.Name = "nuevoVehiculoToolStripMenuItem";
            nuevoVehiculoToolStripMenuItem.Size = new Size(180, 22);
            nuevoVehiculoToolStripMenuItem.Text = "Nuevo Vehiculo";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(185, 61);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(399, 41);
            textBox2.TabIndex = 3;
            textBox2.Text = "BIENVENIDO";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmContenedor";
            Text = "FrmContenedor";
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
        private TextBox textBox2;
    }
}