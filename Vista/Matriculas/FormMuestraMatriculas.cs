using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Matriculas
{
    public partial class FormMuestraMatriculas : Form
    {
        public FormMuestraMatriculas()
        {
            InitializeComponent();
        }

        private void FormMuestraMatriculas_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaMatricula().MostrarListaMatriculas();

            dataGridViewMuestraMatriculas.DataSource = bindingSource;
            dataGridViewMuestraMatriculas.ClearSelection();
        }
    }
}
