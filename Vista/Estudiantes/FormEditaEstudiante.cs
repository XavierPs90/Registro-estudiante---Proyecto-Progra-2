using PracticaLaboratorio2.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Estudiante
{
    public partial class FormEditaEstudiante : Form
    {
        private String usuario;

        public FormEditaEstudiante()
        {
            InitializeComponent();
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private void FormEditaEstudiante_Load(object sender, EventArgs e)
        {
            List<String> estudiante = new List<string>();
            LogicaEstudiante logicaEstudiante = new LogicaEstudiante();
            Boolean resultado;

            if (resultado = logicaEstudiante.CargarEstudianteActual(usuario)) 
            {
                txtCedula.Text = logicaEstudiante.estudiante[0];
                txtCedula.Text = logicaEstudiante.estudiante[1];
                txtCedula.Text = logicaEstudiante.estudiante[2];
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
