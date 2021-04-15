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
    public partial class FormCreaCursos : Form
    {
        LogicaCurso logicaCurso = new LogicaCurso();

        public FormCreaCursos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCurso.Text = "";
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (logicaCurso.CrearCurso(txtCurso.Text.ToLower()))
            {
                txtCurso.Text = "";
            }
        }
    }
}
