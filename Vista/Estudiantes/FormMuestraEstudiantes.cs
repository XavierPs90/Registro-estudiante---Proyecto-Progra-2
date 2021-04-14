using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Estudiantes
{
    public partial class FormMuestraEstudiantes : Form
    {
        public FormMuestraEstudiantes()
        {
            InitializeComponent();
        }

        private void FormMuestraEstudiantes_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla() 
        {
            BindingSource bindingSource = new LogicaEstudiante().MostrarListaEstudiantes();

            dGVMuestraListaEstudiantes.DataSource = bindingSource;
            dGVMuestraListaEstudiantes.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
