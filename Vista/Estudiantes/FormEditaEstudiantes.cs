using System;
using System.Windows.Forms;
using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;

namespace PracticaLaboratorio2.Vista.Estudiante
{
    public partial class FormEditaEstudiantes : Form
    {
        private String cedula, nombre, edad;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormEditaEstudiantes()
        {
            InitializeComponent();
        }

        private void dataGridViewEditaEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormEditaEstudiantes_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dataGridViewEditaEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEditaEstudiantes.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEditaEstudiantes.SelectedCells[0].RowIndex;
                cedula = dataGridViewEditaEstudiantes.Rows[indiceRow].Cells[0].Value.ToString();
                nombre = dataGridViewEditaEstudiantes.Rows[indiceRow].Cells[1].Value.ToString();
                edad = dataGridViewEditaEstudiantes.Rows[indiceRow].Cells[2].Value.ToString();

                txtCedula.Text = cedula;
                txtNombre.Text = nombre;
                txtEdad.Text = edad;

                dataGridViewEditaEstudiantes.ClearSelection();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Student estudianteActual = new Student();
            Student estudianteNuevo = new Student();

            if (txtCedula.Text  != "" || txtNombre.Text != "" || txtEdad.Text != "")
            {
                estudianteActual.Cedula = cedula;
                estudianteActual.Nombre = nombre;
                estudianteActual.Edad = edad;
                estudianteNuevo.Cedula = txtCedula.Text.ToLower();
                estudianteNuevo.Nombre = txtNombre.Text.ToLower();
                estudianteNuevo.Edad = txtEdad.Text.ToLower();

                if (new LogicaEstudiante().EditarEstudiante(estudianteActual, estudianteNuevo))
                {
                    txtCedula.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                }
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaEstudiante().MostrarListaEstudiantes();

            dataGridViewEditaEstudiantes.DataSource = bindingSource;
            dataGridViewEditaEstudiantes.ClearSelection();
        }
    }
}
