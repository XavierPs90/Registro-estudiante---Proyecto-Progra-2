using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Usuarios
{
    public partial class FormEditaUsuarios : Form
    {
        private String usuario, clave, perfil;

        public FormEditaUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
            txtPerfil.Text = perfil;
            Close();
        }

        private void FormEditaUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaUsuario().MostrarListaUsuarios();

            dataGridViewEditaUsuarios.DataSource = bindingSource;
            dataGridViewEditaUsuarios.ClearSelection();
        }

        private void dataGridViewEditaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewEditaUsuarios.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewEditaUsuarios.SelectedCells[0].RowIndex;
                usuario = dataGridViewEditaUsuarios.Rows[indiceRow].Cells[0].Value.ToString();
                clave = dataGridViewEditaUsuarios.Rows[indiceRow].Cells[1].Value.ToString();
                perfil = dataGridViewEditaUsuarios.Rows[indiceRow].Cells[2].Value.ToString();

                txtUsuario.Text = usuario;
                txtClave.Text = clave;
                txtPerfil.Text = perfil;

                dataGridViewEditaUsuarios.ClearSelection();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuarioActual = new Usuario();
            Usuario usuarioNuevo = new Usuario();
            
            if (txtUsuario.Text != "" || txtClave.Text != "" || txtPerfil.Text != "") 
            {
                usuarioActual.User = usuario;
                usuarioActual.Clave = clave;
                usuarioActual.Perfil = perfil;
                usuarioNuevo.User = txtUsuario.Text.ToLower();
                usuarioNuevo.Clave = txtClave.Text.ToLower();
                usuarioNuevo.Perfil = txtPerfil.Text.ToLower();

                if (new LogicaUsuario().EditarUsuario(usuarioActual, usuarioNuevo)) 
                {
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    txtPerfil.Text = "";
                }
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }
    }
}
