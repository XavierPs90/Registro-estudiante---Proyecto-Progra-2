using PracticaLaboratorio2.Datos;
using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista
{
    public partial class FormLogin : Form
    {
        public Boolean loginCorrecto = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUser.Text;
            String pass = txtPass.Text;
            Boolean validaUsuario, validaContrasenia;
            Usuario objUsuario = new Usuario(usuario, pass);

            validaUsuario = new LogicaLogin().verificaUsuario(objUsuario);
            validaContrasenia = new LogicaLogin().verificaContrasenia(objUsuario);
            
            if (validaUsuario == false || validaContrasenia == false)
            {
                MessageBox.Show("Error, datos invalidos");
            }
            else
            {
                this.loginCorrecto = true;
                this.Close();
            }
        }
    }
}
