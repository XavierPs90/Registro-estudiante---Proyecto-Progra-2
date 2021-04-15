using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Periodos
{
    public partial class FormMuestraPeriodos : Form
    {
        public FormMuestraPeriodos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMuestraPeriodos_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaPeriodo().MostrarListaPeriodos();

            dGVMuestraListaPeriodos.DataSource = bindingSource;
            dGVMuestraListaPeriodos.ClearSelection();
        }
    }
}
