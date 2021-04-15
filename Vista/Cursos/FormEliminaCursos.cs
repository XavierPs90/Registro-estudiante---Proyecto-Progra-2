using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Cursos
{
    public partial class FormEliminaCursos : Form
    {
        private String curso;

        public FormEliminaCursos()
        {
            InitializeComponent();
        }

        private void dataGridViewEliminaCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEliminaCursos.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEliminaCursos.SelectedCells[0].RowIndex;
                curso = dataGridViewEliminaCursos.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (curso != "")
            {
                new LogicaCurso().EliminarCurso(curso);
                curso = "";
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaCurso().MostrarListaCursos();

            dataGridViewEliminaCursos.DataSource = bindingSource;
            dataGridViewEliminaCursos.ClearSelection();
            curso = "";
        }

        private void FormEliminaCursos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
