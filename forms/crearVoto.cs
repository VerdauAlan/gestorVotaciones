using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorVotaciones_server.forms
{
    public partial class crearVoto : Form
    {
        ConsultaBD consultaBD = new ConsultaBD();
        String usuarioId;
        public crearVoto(String usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            forms.menuImportante menuImportante = new forms.menuImportante(usuarioId);
            this.Visible = false;
            menuImportante.Show();

        }

        private void crear_Click(object sender, EventArgs e)
        {
            bool verificacion = consultaBD.crearVoto(titulo.Text, tematica.Text, fechaInicio.Text, fechaFin.Text, descripcion.Text);
            if (verificacion)
            {
                MessageBox.Show("Se ha creado la votación exitosamente.");
            }
            else
            {
                MessageBox.Show("Ha fallado exitosamente.");
            }
        }
    }
}
