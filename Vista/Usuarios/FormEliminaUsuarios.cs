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

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormEliminaUsuarios : Form
    {
        private String usuario;

        public FormEliminaUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuario != "")
            {
                new LogicaUsuario().EliminarUsuario(usuario);
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaUsuario().MostrarListaUsuarios();

            dataGridViewEliminaUsuarios.DataSource = bindingSource;
            dataGridViewEliminaUsuarios.ClearSelection();
        }

        private void FormEliminaUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dataGridViewEliminaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEliminaUsuarios.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEliminaUsuarios.SelectedCells[0].RowIndex;
                usuario = dataGridViewEliminaUsuarios.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }
    }
}
