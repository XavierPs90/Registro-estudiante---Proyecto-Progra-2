using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Periodos
{
    public partial class FormCreaPeriodos : Form
    {
        LogicaPeriodo logicaPeriodo = new LogicaPeriodo();

        public FormCreaPeriodos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPeriodo.Text = "";
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (logicaPeriodo.CrearPeriodo(txtPeriodo.Text.ToLower()))
            {
                txtPeriodo.Text = "";
            }
        }
    }
}
