using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormCreaUsuarios : Form
    {
        public FormCreaUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();

            Usuario usuario = new Usuario();

            usuario.User = txtUsuario.Text.ToLower();
            usuario.Clave = txtClave.Text.ToLower();
            usuario.Perfil = comboBoxPerfil.Text.ToLower();

            if (logicaUsuario.CrearUsuario(usuario)) 
            {
                txtUsuario.Text = "";
                txtClave.Text = "";
                comboBoxPerfil.Text = "";
            }
        }
    }
}
