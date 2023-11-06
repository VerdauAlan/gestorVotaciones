using MySqlX.XDevAPI.Common;
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
    public partial class iniciarSesion : Form
    {

        ConsultaBD consultaBD = new ConsultaBD();
        public iniciarSesion()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            this.Visible = false;
            menuInicial.Show();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            bool verificacion = consultaBD.iniciarSesion(email.Text, contrasenia.Text);
            if (verificacion)
            {
                MessageBox.Show("Se ha iniciado sesión exitosamente.");
                forms.menuImportante menuImportante = new forms.menuImportante(consultaBD.iniciarSesion_obtenerDNI(email.Text, contrasenia.Text));
                this.Visible = false;
                menuImportante.Show();
            }
            else
            {
                MessageBox.Show("Ha fallado exitosamente. " + email.Text + " " + contrasenia.Text);
            }
        }
    }
}
