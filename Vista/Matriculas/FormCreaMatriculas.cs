using PracticaLaboratorio2.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Matriculas
{
    public partial class FormCreaMatriculas : Form
    {
        private String usuario, perfil;
        private Boolean resultado, accedeComprobante = false;
        public List<String> cursosDisponibles, periodosDisponibles;
        private List<String> datosEstudiante = new List<string>();
        private LogicaEstudiante logicaEstudiante = new LogicaEstudiante();
        private LogicaMatricula logicaMatricula = new LogicaMatricula();
        private LogicaCurso logicaCurso = new LogicaCurso();
        private LogicaPeriodo logicaPeriodo = new LogicaPeriodo();
        private FormComprobante formComprobante = new FormComprobante();
        
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public FormCreaMatriculas()
        {
            InitializeComponent();
        }

        private void FormMatricula_Load(object sender, EventArgs e)
        {
            if (logicaEstudiante.CargarEstudianteActual(usuario))
            {
                datosEstudiante = logicaEstudiante.estudiante;

                txtCedula.Text = datosEstudiante[0];
                txtNombre.Text = datosEstudiante[1];
                txtEdad.Text = datosEstudiante[2];
                
                txtCedula.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtEdad.ReadOnly = true;

                cursosDisponibles = logicaCurso.ObtenerCursos();
                
                foreach (String curso in cursosDisponibles) 
                {
                    comboBoxCurso.Items.Add(curso);
                }

                periodosDisponibles = logicaPeriodo.ObtenerPeriodos();

                foreach (String periodo in periodosDisponibles)
                {
                    comboBoxPeriodo.Items.Add(periodo);
                }

                accedeComprobante = true;
            }
            else
                MessageBox.Show("Primero debe crear un usuario y un estudiante para realizar la matricula", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBoxCursos.Items.Add(comboBoxCurso.SelectedItem);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            listBoxCursos.Items.Remove(listBoxCursos.SelectedItem);
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (accedeComprobante == true && formComprobante.Periodo != null)
            {
                formComprobante.ShowDialog();
            }
            else
                MessageBox.Show("Primero se debe realizar la matricula", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (comboBoxPeriodo.SelectedIndex > 0 || listBoxCursos.Items.Count > 0)
            {
                foreach (String curso in listBoxCursos.Items)
                {
                    resultado = logicaMatricula.AsignarCursos(Usuario, curso);
                }

                if (resultado) 
                {
                    logicaMatricula.CrearMatricula(Usuario, comboBoxPeriodo.SelectedItem.ToString());
                    
                    // Variables para enviar los datos al comprobante
                    formComprobante.Periodo = comboBoxPeriodo.SelectedItem.ToString();
                    formComprobante.Cedula = datosEstudiante[0].ToString();
                    formComprobante.Nombre = datosEstudiante[1].ToString();
                    formComprobante.Usuario = usuario;
                    foreach (String curso in listBoxCursos.Items)
                    {
                        formComprobante.cursos.Add(curso);
                    }

                    Usuario = "";
                    datosEstudiante.Clear();
                }
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            comboBoxPeriodo.Items.Clear();
            comboBoxCurso.Items.Clear();
            listBoxCursos.Items.Clear();
            logicaMatricula.VaciarListas();

            if (cursosDisponibles.Count > 0) 
                cursosDisponibles.RemoveRange(0, cursosDisponibles.Count);

            if (periodosDisponibles.Count > 0)
                periodosDisponibles.RemoveRange(0, periodosDisponibles.Count);

            Close();
        }

        public void EliminarMatricula() 
        {
            
        }
    }
}
