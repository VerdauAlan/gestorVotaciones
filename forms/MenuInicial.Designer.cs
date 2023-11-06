namespace GestorVotaciones_server
{
    partial class MenuInicial
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
            hoja = new PictureBox();
            avotar = new PictureBox();
            iniciarSesion = new PictureBox();
            registrarse = new PictureBox();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)hoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avotar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iniciarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registrarse).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // hoja
            // 
            hoja.BackColor = Color.Transparent;
            hoja.Image = Properties.Resources.menuInicial_hoja;
            hoja.Location = new Point(263, 165);
            hoja.Name = "hoja";
            hoja.Size = new Size(259, 210);
            hoja.SizeMode = PictureBoxSizeMode.AutoSize;
            hoja.TabIndex = 0;
            hoja.TabStop = false;
            // 
            // avotar
            // 
            avotar.Image = Properties.Resources.menuInicial_aVotar;
            avotar.Location = new Point(304, 190);
            avotar.Name = "avotar";
            avotar.Size = new Size(177, 77);
            avotar.SizeMode = PictureBoxSizeMode.AutoSize;
            avotar.TabIndex = 1;
            avotar.TabStop = false;
            // 
            // iniciarSesion
            // 
            iniciarSesion.BackColor = Color.Transparent;
            iniciarSesion.Image = Properties.Resources.menuInicial_iniciarSesion;
            iniciarSesion.Location = new Point(163, 312);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(211, 60);
            iniciarSesion.SizeMode = PictureBoxSizeMode.AutoSize;
            iniciarSesion.TabIndex = 2;
            iniciarSesion.TabStop = false;
            iniciarSesion.Click += iniciarSesion_Click;
            // 
            // registrarse
            // 
            registrarse.Image = Properties.Resources.menuInicial_registrarse;
            registrarse.Location = new Point(408, 312);
            registrarse.Name = "registrarse";
            registrarse.Size = new Size(181, 59);
            registrarse.SizeMode = PictureBoxSizeMode.AutoSize;
            registrarse.TabIndex = 3;
            registrarse.TabStop = false;
            registrarse.Click += registrarse_Click;
            // 
            // panel
            // 
            panel.Controls.Add(registrarse);
            panel.Controls.Add(iniciarSesion);
            panel.Controls.Add(avotar);
            panel.Controls.Add(hoja);
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(800, 600);
            panel.TabIndex = 4;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(784, 561);
            Controls.Add(panel);
            Name = "MenuInicial";
            Text = "Gestor de votaciones";
            ((System.ComponentModel.ISupportInitialize)hoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)avotar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iniciarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)registrarse).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hoja;
        private PictureBox avotar;
        private PictureBox iniciarSesion;
        private PictureBox registrarse;
        private Panel panel;
    }
}