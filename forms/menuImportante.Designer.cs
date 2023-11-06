namespace GestorVotaciones_server.forms
{
    partial class menuImportante
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
            pictureBox1 = new PictureBox();
            btn_crearVotacion = new PictureBox();
            verVotacionesVigentes = new PictureBox();
            tablonParaVotar = new PictureBox();
            resultados = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearVotacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verVotacionesVigentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablonParaVotar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultados).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menuImportante_logo;
            pictureBox1.Location = new Point(152, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_crearVotacion
            // 
            btn_crearVotacion.Image = Properties.Resources.menuImportante_CrearVotacion;
            btn_crearVotacion.Location = new Point(200, 119);
            btn_crearVotacion.Name = "btn_crearVotacion";
            btn_crearVotacion.Size = new Size(394, 69);
            btn_crearVotacion.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_crearVotacion.TabIndex = 1;
            btn_crearVotacion.TabStop = false;
            btn_crearVotacion.Click += btn_crearVotacion_Click;
            // 
            // verVotacionesVigentes
            // 
            verVotacionesVigentes.Image = Properties.Resources.menuImportante_VerVotacionesVigentes;
            verVotacionesVigentes.Location = new Point(195, 200);
            verVotacionesVigentes.Name = "verVotacionesVigentes";
            verVotacionesVigentes.Size = new Size(402, 70);
            verVotacionesVigentes.SizeMode = PictureBoxSizeMode.AutoSize;
            verVotacionesVigentes.TabIndex = 2;
            verVotacionesVigentes.TabStop = false;
            // 
            // tablonParaVotar
            // 
            tablonParaVotar.Image = Properties.Resources.menuImportante_tablonParaVotar;
            tablonParaVotar.Location = new Point(200, 276);
            tablonParaVotar.Name = "tablonParaVotar";
            tablonParaVotar.Size = new Size(406, 71);
            tablonParaVotar.SizeMode = PictureBoxSizeMode.AutoSize;
            tablonParaVotar.TabIndex = 3;
            tablonParaVotar.TabStop = false;
            tablonParaVotar.Click += tablonParaVotar_Click;
            // 
            // resultados
            // 
            resultados.Image = Properties.Resources.menuImportante_Resultados;
            resultados.Location = new Point(195, 363);
            resultados.Name = "resultados";
            resultados.Size = new Size(410, 69);
            resultados.SizeMode = PictureBoxSizeMode.AutoSize;
            resultados.TabIndex = 4;
            resultados.TabStop = false;
            // 
            // menuImportante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(784, 561);
            Controls.Add(resultados);
            Controls.Add(tablonParaVotar);
            Controls.Add(verVotacionesVigentes);
            Controls.Add(btn_crearVotacion);
            Controls.Add(pictureBox1);
            Name = "menuImportante";
            Text = "Gestor votaciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_crearVotacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)verVotacionesVigentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablonParaVotar).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btn_crearVotacion;
        private PictureBox verVotacionesVigentes;
        private PictureBox tablonParaVotar;
        private PictureBox resultados;
    }
}