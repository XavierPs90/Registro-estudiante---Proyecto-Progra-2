using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Estudiante
{
    public partial class FormEliminaEstudiantes : Form
    {
        private String cedula;

        public FormEliminaEstudiantes()
        {
            InitializeComponent();
        }

        private void dataGridViewEliminaEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEliminaEstudiantes.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEliminaEstudiantes.SelectedCells[0].RowIndex;
                cedula = dataGridViewEliminaEstudiantes.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cedula != "")
            {
                new LogicaEstudiante().EliminarEstudiante(cedula);
                cedula = "";
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaEstudiante().MostrarListaEstudiantes();

            dataGridViewEliminaEstudiantes.DataSource = bindingSource;
            dataGridViewEliminaEstudiantes.ClearSelection();
            cedula = "";
        }

        private void FormEliminaEstudiantes_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
