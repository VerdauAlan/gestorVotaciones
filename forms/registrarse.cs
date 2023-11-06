using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorVotaciones_server.forms
{
    public partial class registrarse : Form
    {
        ConsultaBD consultaBD = new ConsultaBD();
        public registrarse()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Visible = false;
            menuInicial.Show();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            bool verificacion = consultaBD.registrarse(email.Text, contrasenia.Text, DNI.Text, nombre.Text, apellido.Text);
            if (verificacion)
            {
                MessageBox.Show("Se ha registrado exitosamente.");
                forms.iniciarSesion iniciarSesion = new forms.iniciarSesion();
                this.Visible = false;
                iniciarSesion.Show();
            }
            else
            {
                MessageBox.Show("Ha fallado exitosamente.");
            }
        }
    }
}
