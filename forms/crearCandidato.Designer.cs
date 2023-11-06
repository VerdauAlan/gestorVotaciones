namespace GestorVotaciones_server.forms
{
    partial class crearCandidato
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
            hoja = new PictureBox();
            label3 = new Label();
            DNI = new TextBox();
            label4 = new Label();
            nombre = new TextBox();
            label5 = new Label();
            apellido = new TextBox();
            label1 = new Label();
            propuesta = new TextBox();
            btn_registrarse = new PictureBox();
            lb_candidato = new Label();
            ((System.ComponentModel.ISupportInitialize)hoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_registrarse).BeginInit();
            SuspendLayout();
            // 
            // hoja
            // 
            hoja.Image = Properties.Resources.menuInicial_hoja;
            hoja.Location = new Point(154, 52);
            hoja.Name = "hoja";
            hoja.Size = new Size(492, 347);
            hoja.SizeMode = PictureBoxSizeMode.StretchImage;
            hoja.TabIndex = 3;
            hoja.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(191, 103);
            label3.Name = "label3";
            label3.Size = new Size(44, 22);
            label3.TabIndex = 10;
            label3.Text = "DNI";
            // 
            // DNI
            // 
            DNI.Location = new Point(307, 102);
            DNI.Name = "DNI";
            DNI.Size = new Size(274, 23);
            DNI.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(191, 141);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 13;
            label4.Text = "Nombre";
            // 
            // nombre
            // 
            nombre.Location = new Point(307, 140);
            nombre.Name = "nombre";
            nombre.Size = new Size(274, 23);
            nombre.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(191, 186);
            label5.Name = "label5";
            label5.Size = new Size(81, 22);
            label5.TabIndex = 15;
            label5.Text = "Apellido";
            // 
            // apellido
            // 
            apellido.Location = new Point(307, 185);
            apellido.Name = "apellido";
            apellido.Size = new Size(274, 23);
            apellido.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(191, 235);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 17;
            label1.Text = "Propuesta";
            // 
            // propuesta
            // 
            propuesta.Location = new Point(307, 234);
            propuesta.Name = "propuesta";
            propuesta.Size = new Size(274, 23);
            propuesta.TabIndex = 18;
            // 
            // btn_registrarse
            // 
            btn_registrarse.Image = Properties.Resources.menuInicial_registrarse;
            btn_registrarse.Location = new Point(298, 305);
            btn_registrarse.Name = "btn_registrarse";
            btn_registrarse.Size = new Size(198, 63);
            btn_registrarse.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_registrarse.TabIndex = 19;
            btn_registrarse.TabStop = false;
            btn_registrarse.Click += btn_registrarse_Click;
            // 
            // lb_candidato
            // 
            lb_candidato.AutoSize = true;
            lb_candidato.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_candidato.Location = new Point(327, 62);
            lb_candidato.Name = "lb_candidato";
            lb_candidato.Size = new Size(91, 22);
            lb_candidato.TabIndex = 20;
            lb_candidato.Text = "Candidato";
            // 
            // crearCandidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(800, 450);
            Controls.Add(lb_candidato);
            Controls.Add(btn_registrarse);
            Controls.Add(propuesta);
            Controls.Add(label1);
            Controls.Add(apellido);
            Controls.Add(label5);
            Controls.Add(nombre);
            Controls.Add(label4);
            Controls.Add(DNI);
            Controls.Add(label3);
            Controls.Add(hoja);
            Name = "crearCandidato";
            Text = "crearCandidato";
            ((System.ComponentModel.ISupportInitialize)hoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_registrarse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hoja;
        private Label label3;
        private TextBox DNI;
        private Label label4;
        private TextBox nombre;
        private Label label5;
        private TextBox apellido;
        private Label label1;
        private TextBox propuesta;
        private PictureBox btn_registrarse;
        private Label lb_candidato;
    }
}