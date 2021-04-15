using System;
using System.Windows.Forms;
using PracticaLaboratorio2.Logica;

namespace PracticaLaboratorio2.Vista.Periodos
{
    public partial class FormEditaPeriodos : Form
    {
        private String periodo;

        public FormEditaPeriodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPeriodo.Text = "";
            Close();
        }

        private void dataGridViewCreaPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEditaPeriodos.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEditaPeriodos.SelectedCells[0].RowIndex;
                periodo = dataGridViewEditaPeriodos.Rows[indiceRow].Cells[0].Value.ToString();

                txtPeriodo.Text = periodo;

                dataGridViewEditaPeriodos.ClearSelection();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtPeriodo.Text != "")
            {
                if (new LogicaPeriodo().EditarPeriodo(periodo, txtPeriodo.Text))
                {
                    txtPeriodo.Text = "";
                }
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        private void FormEditaPeriodos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaPeriodo().MostrarListaPeriodos();

            dataGridViewEditaPeriodos.DataSource = bindingSource;
            dataGridViewEditaPeriodos.ClearSelection();
        }
    }
}
