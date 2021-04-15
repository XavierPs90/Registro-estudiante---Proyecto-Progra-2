using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaLaboratorio2.Logica;

namespace PracticaLaboratorio2.Vista.Cursos
{
    public partial class FormMuestraCursos : Form
    {
        public FormMuestraCursos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void FormMuestraCursos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();  
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaCurso().MostrarListaCursos();

            dGVMuestraListaEstudiantes.DataSource = bindingSource;
            dGVMuestraListaEstudiantes.ClearSelection();
        }
    }
}
