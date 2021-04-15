using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Periodos
{
    public partial class FormEliminaPeriodos : Form
    {
        private String periodo;

        public FormEliminaPeriodos()
        {
            InitializeComponent();
        }

        private void dataGridViewEliminaPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEliminaPeriodos.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEliminaPeriodos.SelectedCells[0].RowIndex;
                periodo = dataGridViewEliminaPeriodos.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (periodo != "")
            {
                new LogicaPeriodo().EliminarPeriodo(periodo);
                periodo = "";
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaPeriodo().MostrarListaPeriodos();

            dataGridViewEliminaPeriodos.DataSource = bindingSource;
            dataGridViewEliminaPeriodos.ClearSelection();
            periodo = "";
        }

        private void FormEliminaPeriodos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
