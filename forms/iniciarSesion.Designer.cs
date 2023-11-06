namespace GestorVotaciones_server.forms
{
    partial class iniciarSesion
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
            btn_iniciarSesion = new PictureBox();
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            contrasenia = new TextBox();
            volver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volver).BeginInit();
            SuspendLayout();
            // 
            // hoja
            // 
            hoja.Image = Properties.Resources.menuInicial_hoja;
            hoja.Location = new Point(140, 137);
            hoja.Name = "hoja";
            hoja.Size = new Size(492, 263);
            hoja.SizeMode = PictureBoxSizeMode.StretchImage;
            hoja.TabIndex = 0;
            hoja.TabStop = false;
            // 
            // btn_iniciarSesion
            // 
            btn_iniciarSesion.Image = Properties.Resources.menuInicial_iniciarSesion;
            btn_iniciarSesion.Location = new Point(471, 360);
            btn_iniciarSesion.Name = "btn_iniciarSesion";
            btn_iniciarSesion.Size = new Size(198, 63);
            btn_iniciarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_iniciarSesion.TabIndex = 1;
            btn_iniciarSesion.TabStop = false;
            btn_iniciarSesion.Click += btn_iniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 205);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(266, 204);
            email.Name = "email";
            email.Size = new Size(274, 23);
            email.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 263);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // contrasenia
            // 
            contrasenia.Location = new Point(266, 262);
            contrasenia.Name = "contrasenia";
            contrasenia.PasswordChar = '*';
            contrasenia.Size = new Size(274, 23);
            contrasenia.TabIndex = 6;
            // 
            // volver
            // 
            volver.Image = Properties.Resources.menuInicial_volver;
            volver.Location = new Point(106, 360);
            volver.Name = "volver";
            volver.Size = new Size(198, 63);
            volver.SizeMode = PictureBoxSizeMode.StretchImage;
            volver.TabIndex = 7;
            volver.TabStop = false;
            volver.Click += volver_Click;
            // 
            // iniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(784, 561);
            Controls.Add(volver);
            Controls.Add(contrasenia);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(btn_iniciarSesion);
            Controls.Add(hoja);
            Name = "iniciarSesion";
            Text = "Gestor votaciones";
            ((System.ComponentModel.ISupportInitialize)hoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_iniciarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)volver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hoja;
        private PictureBox btn_iniciarSesion;
        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox contrasenia;
        private PictureBox volver;
    }
}