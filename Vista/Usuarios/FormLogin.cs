using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;
using PracticaLaboratorio2.Pruebas.Vista;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista
{
    public partial class FormLogin : Form
    {
        private Boolean loginCorrecto;
        private String perfil, usuario;
        FormRegistraUsuario formRegistraUsuario = new FormRegistraUsuario();

        public Boolean LoginCorrecto
        {
            get { return loginCorrecto; }
            set { loginCorrecto = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario = txtUsuario.Text.ToLower();

            Usuario usuario = new Usuario
            {
                User = txtUsuario.Text.ToLower(),
                Clave = txtClave.Text
            };

            usuario = new LogicaUsuario().ValidarUsuario(usuario);

            Perfil = usuario.Perfil;
            LoginCorrecto = usuario.LoginCorrecto;

            if (LoginCorrecto == true)
            {
                Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            formRegistraUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
