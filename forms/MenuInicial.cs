using System.Xml.Serialization;

namespace GestorVotaciones_server
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            // Agrega el contenido del formulario de inicio de sesión
            forms.iniciarSesion iniciarSesion = new forms.iniciarSesion();
            this.Visible = false;
            iniciarSesion.Show();
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            forms.registrarse registrarse = new forms.registrarse();
            this.Visible = false;
            registrarse.Show();
        }
    }
}