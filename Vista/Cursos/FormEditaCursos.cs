using PracticaLaboratorio2.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Cursos
{
    public partial class FormEditaCursos : Form
    {
        private String curso;

        public FormEditaCursos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditaCursos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dataGridViewEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEditaCursos.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEditaCursos.SelectedCells[0].RowIndex;
                curso = dataGridViewEditaCursos.Rows[indiceRow].Cells[0].Value.ToString();
                
                txtCurso.Text = curso;
                
                dataGridViewEditaCursos.ClearSelection();
            }
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaCurso().MostrarListaCursos();

            dataGridViewEditaCursos.DataSource = bindingSource;
            dataGridViewEditaCursos.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text != "")
            {
                if (new LogicaCurso().EditarCursos(curso, txtCurso.Text))
                {
                    txtCurso.Text = "";
                }
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }
    }
}
