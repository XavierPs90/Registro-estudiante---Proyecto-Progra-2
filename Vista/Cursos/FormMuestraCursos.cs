using System;
using System.Windows.Forms;
using PracticaLaboratorio2.Logica;

namespace PracticaLaboratorio2.Vista.Cursos
{
    public partial class FormMuestraCursos : Form
    {
        public FormMuestraCursos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMuestraCursos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();  
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaCurso().MostrarListaCursos();

            dGVMuestraListaCursos.DataSource = bindingSource;
            dGVMuestraListaCursos.ClearSelection();
        }
    }
}
