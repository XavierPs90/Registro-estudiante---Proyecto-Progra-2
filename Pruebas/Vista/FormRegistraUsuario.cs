using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Pruebas.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Pruebas.Vista
{
    public partial class FormRegistraUsuario : Form
    {
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
            LogUsuario logUsuario = new LogUsuario();
            Usuario usuario = new Usuario();
            String confirmaClave = txtConfirmarClave.Text.ToLower();

            usuario.User = txtUsuario.Text.ToLower();
            usuario.Clave = txtClave.Text.ToLower();
            usuario.Perfil = "estudiante";
            logUsuario.RegistrarUsuario(usuario, confirmaClave);

            
        }
    }
}
