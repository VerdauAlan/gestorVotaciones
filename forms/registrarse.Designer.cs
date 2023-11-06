namespace GestorVotaciones_server.forms
{
    partial class registrarse
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
            label1 = new Label();
            email = new TextBox();
            contrasenia = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DNI = new TextBox();
            nombre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            apellido = new TextBox();
            volver = new PictureBox();
            btn_registrarse = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_registrarse).BeginInit();
            SuspendLayout();
            // 
            // hoja
            // 
            hoja.Image = Properties.Resources.menuInicial_hoja;
            hoja.Location = new Point(146, 108);
            hoja.Name = "hoja";
            hoja.Size = new Size(492, 304);
            hoja.SizeMode = PictureBoxSizeMode.StretchImage;
            hoja.TabIndex = 1;
            hoja.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 141);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(265, 140);
            email.Name = "email";
            email.Size = new Size(274, 23);
            email.TabIndex = 5;
            // 
            // contrasenia
            // 
            contrasenia.Location = new Point(265, 179);
            contrasenia.Name = "contrasenia";
            contrasenia.PasswordChar = '*';
            contrasenia.Size = new Size(274, 23);
            contrasenia.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 180);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 219);
            label3.Name = "label3";
            label3.Size = new Size(44, 22);
            label3.TabIndex = 9;
            label3.Text = "DNI";
            // 
            // DNI
            // 
            DNI.Location = new Point(265, 218);
            DNI.Name = "DNI";
            DNI.Size = new Size(274, 23);
            DNI.TabIndex = 10;
            // 
            // nombre
            // 
            nombre.Location = new Point(265, 256);
            nombre.Name = "nombre";
            nombre.Size = new Size(274, 23);
            nombre.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 257);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 12;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(160, 299);
            label5.Name = "label5";
            label5.Size = new Size(81, 22);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // apellido
            // 
            apellido.Location = new Point(265, 298);
            apellido.Name = "apellido";
            apellido.Size = new Size(274, 23);
            apellido.TabIndex = 14;
            // 
            // volver
            // 
            volver.Image = Properties.Resources.menuInicial_volver;
            volver.Location = new Point(111, 358);
            volver.Name = "volver";
            volver.Size = new Size(198, 63);
            volver.SizeMode = PictureBoxSizeMode.StretchImage;
            volver.TabIndex = 15;
            volver.TabStop = false;
            volver.Click += volver_Click;
            // 
            // btn_registrarse
            // 
            btn_registrarse.Image = Properties.Resources.menuInicial_registrarse;
            btn_registrarse.Location = new Point(455, 358);
            btn_registrarse.Name = "btn_registrarse";
            btn_registrarse.Size = new Size(198, 63);
            btn_registrarse.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_registrarse.TabIndex = 16;
            btn_registrarse.TabStop = false;
            btn_registrarse.Click += btn_registrarse_Click;
            // 
            // registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(784, 561);
            Controls.Add(btn_registrarse);
            Controls.Add(volver);
            Controls.Add(apellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nombre);
            Controls.Add(DNI);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(contrasenia);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(hoja);
            Name = "registrarse";
            Text = "Gestor votaciones";
            ((System.ComponentModel.ISupportInitialize)hoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)volver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_registrarse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hoja;
        private Label label1;
        private TextBox email;
        private TextBox contrasenia;
        private Label label2;
        private Label label3;
        private TextBox DNI;
        private TextBox nombre;
        private Label label4;
        private Label label5;
        private TextBox apellido;
        private PictureBox volver;
        private PictureBox btn_registrarse;
    }
}