using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormMuestraUsuarios : Form
    {
        private String usuario, perfil;
        BindingSource bindingSource;

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

        public FormMuestraUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ActualizarTabla()
        {
            if (perfil == "administrador")
                bindingSource = new LogicaUsuario().MostrarListaUsuarios();
            else
                bindingSource = new LogicaUsuario().MostrarUsuarioEspecífico(usuario);

            dataGridViewMuestraUsuarios.DataSource = bindingSource;
            dataGridViewMuestraUsuarios.ClearSelection();
        }

        private void FormMuestraUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
