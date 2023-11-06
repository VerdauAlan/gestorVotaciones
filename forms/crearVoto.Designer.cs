namespace GestorVotaciones_server.forms
{
    partial class crearVoto
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
            volver = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            crear = new PictureBox();
            titulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            descripcion = new TextBox();
            tematica = new TextBox();
            fechaInicio = new DateTimePicker();
            fechaFin = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)hoja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crear).BeginInit();
            SuspendLayout();
            // 
            // hoja
            // 
            hoja.Image = Properties.Resources.menuInicial_hoja;
            hoja.Location = new Point(146, 132);
            hoja.Name = "hoja";
            hoja.Size = new Size(492, 347);
            hoja.SizeMode = PictureBoxSizeMode.StretchImage;
            hoja.TabIndex = 2;
            hoja.TabStop = false;
            // 
            // volver
            // 
            volver.Image = Properties.Resources.menuInicial_volver;
            volver.Location = new Point(100, 459);
            volver.Name = "volver";
            volver.Size = new Size(153, 43);
            volver.SizeMode = PictureBoxSizeMode.StretchImage;
            volver.TabIndex = 16;
            volver.TabStop = false;
            volver.Click += volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 158);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 17;
            label1.Text = "Titulo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.crearVoto_logo;
            pictureBox1.Location = new Point(189, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // crear
            // 
            crear.Image = Properties.Resources.crearVoto_crear;
            crear.Location = new Point(510, 462);
            crear.Name = "crear";
            crear.Size = new Size(194, 40);
            crear.SizeMode = PictureBoxSizeMode.AutoSize;
            crear.TabIndex = 19;
            crear.TabStop = false;
            crear.Click += crear_Click;
            // 
            // titulo
            // 
            titulo.Location = new Point(264, 157);
            titulo.Name = "titulo";
            titulo.Size = new Size(274, 23);
            titulo.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 203);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 21;
            label2.Text = "Tematica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 257);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 22;
            label3.Text = "Fecha de inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(171, 309);
            label4.Name = "label4";
            label4.Size = new Size(179, 22);
            label4.TabIndex = 23;
            label4.Text = "Fecha de finalización";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(171, 363);
            label5.Name = "label5";
            label5.Size = new Size(107, 22);
            label5.TabIndex = 24;
            label5.Text = "Descripción";
            // 
            // descripcion
            // 
            descripcion.Location = new Point(298, 365);
            descripcion.Name = "descripcion";
            descripcion.ScrollBars = ScrollBars.Vertical;
            descripcion.Size = new Size(274, 23);
            descripcion.TabIndex = 25;
            // 
            // tematica
            // 
            tematica.Location = new Point(264, 202);
            tematica.Name = "tematica";
            tematica.ScrollBars = ScrollBars.Vertical;
            tematica.Size = new Size(274, 23);
            tematica.TabIndex = 26;
            // 
            // fechaInicio
            // 
            fechaInicio.Location = new Point(325, 257);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(200, 23);
            fechaInicio.TabIndex = 27;
            // 
            // fechaFin
            // 
            fechaFin.Location = new Point(372, 309);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(200, 23);
            fechaFin.TabIndex = 28;
            // 
            // crearVoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 223);
            ClientSize = new Size(784, 561);
            Controls.Add(fechaFin);
            Controls.Add(fechaInicio);
            Controls.Add(tematica);
            Controls.Add(descripcion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titulo);
            Controls.Add(crear);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(volver);
            Controls.Add(hoja);
            Name = "crearVoto";
            Text = "Gestor votaciones";
            ((System.ComponentModel.ISupportInitialize)hoja).EndInit();
            ((System.ComponentModel.ISupportInitialize)volver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)crear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hoja;
        private PictureBox volver;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox crear;
        private TextBox titulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox descripcion;
        private TextBox tematica;
        private DateTimePicker fechaInicio;
        private DateTimePicker fechaFin;
    }
}