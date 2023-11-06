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
    public partial class menuImportante : Form
    {
        String usuarioId;
        public menuImportante(String usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        private void btn_crearVotacion_Click(object sender, EventArgs e)
        {
            forms.crearVoto crearVoto = new forms.crearVoto(usuarioId);
            this.Visible = false;
            crearVoto.Show();
        }

        private void tablonParaVotar_Click(object sender, EventArgs e)
        {
            forms.tablonVotar tablonVotar = new forms.tablonVotar(usuarioId);
            this.Visible = false;
            tablonVotar.Show();
        }
    }
}
