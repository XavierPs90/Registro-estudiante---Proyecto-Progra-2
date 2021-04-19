using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Matriculas
{
    public partial class FormRegistraUsuario : Form
    {
        private LogicaUsuario logicaUsuario = new LogicaUsuario();
        private Clase.Usuario usuario = new Clase.Usuario();
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
                logicaUsuario.RegistraUsuarioTablaEstudiante(usuario);
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtConfirmarClave.Text = "";
            }
        }
    }
}
