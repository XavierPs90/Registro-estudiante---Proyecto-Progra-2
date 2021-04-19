using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Matriculas
{
    public partial class FormEliminaMatriculas : Form
    {
        String usuario, cedula;
        LogicaMatricula logicaMatricula = new LogicaMatricula();

        /*public String Usuario 
        {
            get { return usuario; }
            set { usuario = value; }
        }*/

        public FormEliminaMatriculas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cedula != "")
            {
                usuario = logicaMatricula.CargarUsuarioMatricula(cedula);
                logicaMatricula.EliminarMatriculas(usuario);
                cedula = "";
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        private void FormEliminaMatriculas_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaMatricula().MostrarListaMatriculas();

            dataGridViewEliminaMatriculas.DataSource = bindingSource;
            dataGridViewEliminaMatriculas.ClearSelection();
        }

        private void dataGridViewEliminaMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEliminaMatriculas.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEliminaMatriculas.SelectedCells[0].RowIndex;
                cedula = dataGridViewEliminaMatriculas.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }
    }
}
