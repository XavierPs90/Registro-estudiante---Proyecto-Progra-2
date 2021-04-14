using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormMuestraUsuarios : Form
    {
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
            BindingSource bindingSource = new LogicaUsuario().MostrarListaUsuarios();

            dataGridViewMuestraUsuarios.DataSource = bindingSource;
            dataGridViewMuestraUsuarios.ClearSelection();
        }

        private void FormMuestraUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
