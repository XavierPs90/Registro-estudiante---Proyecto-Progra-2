using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;
using PracticaLaboratorio2.Clase;

namespace PracticaLaboratorio2.Vista.Estudiantes
{
    public partial class FormCreaEstudiante : Form
    {
        private String usuario, perfil;

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

        public FormCreaEstudiante()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string cedula, nombre, edad;
            Student estudiante = new Student();

            cedula = txtCedula.Text;
            nombre = txtNombre.Text;
            edad = txtEdad.Text;
            
            estudiante.Cedula = cedula;
            estudiante.Nombre = nombre;
            estudiante.Edad = edad;
            estudiante.Usuario = usuario;

            LogicaEstudiante logicaEstudiante = new LogicaEstudiante();

            if (perfil == "administrador")
            {
                if (logicaEstudiante.CrearEstudiantes(estudiante))
                {
                    txtCedula.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                }
            }
            else
            {
                if (logicaEstudiante.CrearEstudiante(estudiante))
                {
                    txtCedula.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                }
            }
        }
    }
}
