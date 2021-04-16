using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Pruebas.Vista
{
    public partial class FormRegistraUsuario : Form
    {
        private LogicaUsuario logicaUsuario = new LogicaUsuario();
        private Usuario usuario = new Usuario();
        private String confirmaClave;

        public FormRegistraUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            confirmaClave = txtConfirmarClave.Text.ToLower();
            usuario.User = txtUsuario.Text.ToLower();
            usuario.Clave = txtClave.Text.ToLower();
            usuario.Perfil = "estudiante";

            if (logicaUsuario.RegistrarUsuario(usuario, confirmaClave)) 
            {
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtConfirmarClave.Text = "";
            }
        }
    }
}
