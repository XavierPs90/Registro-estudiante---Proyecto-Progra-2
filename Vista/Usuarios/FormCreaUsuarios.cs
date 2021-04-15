using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormCreaUsuarios : Form
    {
        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public FormCreaUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            comboBoxPerfil.SelectedItem = null;
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            Usuario usuario = new Usuario();
            usuario.User = txtUsuario.Text.ToLower();
            usuario.Clave = txtClave.Text.ToLower();
            usuario.Perfil = comboBoxPerfil.SelectedItem.ToString().ToLower();

            if (logicaUsuario.CrearUsuario(usuario)) 
            {
                this.usuario = txtUsuario.Text.ToLower();
                txtUsuario.Text = "";
                txtClave.Text = "";
                comboBoxPerfil.Text = "";
            }
        }
    }
}
