using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Cursos
{
    public partial class FormEliminaCursos : Form
    {
        public FormEliminaCursos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
