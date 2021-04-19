using PracticaLaboratorio2.Logica;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Estudiantes
{
    public partial class FormMuestraEstudiantes : Form
    {
        String usuario, perfil;
        BindingSource bindingSource;

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
            if (perfil == "administrador")
                bindingSource = new LogicaEstudiante().MostrarListaEstudiantes();
            else
                bindingSource = new LogicaEstudiante().MostrarEstudianteEspecífico(usuario);

            dGVMuestraListaEstudiantes.DataSource = bindingSource;
            dGVMuestraListaEstudiantes.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
