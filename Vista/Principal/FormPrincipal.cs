using PracticaLaboratorio2.Logica;
using PracticaLaboratorio2.Vista;
using PracticaLaboratorio2.Vista.Cursos;
using PracticaLaboratorio2.Vista.Estudiante;
using PracticaLaboratorio2.Vista.Estudiantes;
using PracticaLaboratorio2.Vista.Herramientas;
using PracticaLaboratorio2.Vista.Matriculas;
using PracticaLaboratorio2.Vista.Periodos;
using PracticaLaboratorio2.Vista.Usuarios;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2
{
    public partial class FormPrincipal : Form
    {
        private FormLogin formLogin = new FormLogin();
        String perfil;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        /*-------------------------------------------------------------
         *----------------------METODOS-PRINCIPAL---------------------- 
         ------------------------------------------------------------*/

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            formLogin.ShowDialog();

            if (formLogin.LoginCorrecto == false)
            {
                Close();
            }

            perfil = formLogin.Perfil;
            VerificarPerfil();
        }

        private void VerificarPerfil()
        {
            if (perfil != "administrador")
            {
                eliminarToolStripMenuEstudiantes.Enabled = false;
                eliminarToolStripMenuEstudiantes.Visible = false;
                crearToolStripMenuEstudiantes.Enabled = false;
                crearToolStripMenuEstudiantes.Visible = false;
            }
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-ARCHIVO------------------------- 
         ------------------------------------------------------------*/

        private void cerrarSesiónToolStripMenuArchivo_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        private void salirToolStripMenuArchivo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-USUARIOS------------------------ 
         ------------------------------------------------------------*/

        private void crearToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormCreaUsuarios formCreaUsuarios = new FormCreaUsuarios();

            formCreaUsuarios.ShowDialog();
        }

        private void editarToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormEditaUsuarios formEditaUsuarios = new FormEditaUsuarios();

            formEditaUsuarios.ShowDialog();
        }

        private void eliminarToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormEliminaUsuarios formEliminaUsuarios = new FormEliminaUsuarios();

            formEliminaUsuarios.ShowDialog();
        }

        private void mostrarListaToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            FormMuestraUsuarios formMuestraUsuarios = new FormMuestraUsuarios();

            formMuestraUsuarios.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-ESTUDIANTES--------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuEstudiante_Click(object sender, EventArgs e)
        {
            FormCreaEstudiante formCreaEstudiante = new FormCreaEstudiante();
            
            formCreaEstudiante.ShowDialog();
        }

        private void editarToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            if (perfil == "administrador")
            {
                FormEditaEstudiantes formEditaEstudiantes = new FormEditaEstudiantes();
                
                formEditaEstudiantes.ShowDialog();
            }
            else
            {
                FormEditaEstudiante formEditaEstudiante = new FormEditaEstudiante();
                LogicaUsuario logicaUsuario = new LogicaUsuario();

                if (logicaUsuario.CargarNombre(formLogin.Usuario) != "")
                {
                    formEditaEstudiante.Usuario = formLogin.Usuario;
                    formEditaEstudiante.ShowDialog();
                }
            }
        }

        private void eliminarToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            FormEliminaEstudiantes formEliminaEstudiantes = new FormEliminaEstudiantes();

            formEliminaEstudiantes.ShowDialog();
        }

        private void mostrarListaToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            FormMuestraEstudiantes formMuestraEstudiantes = new FormMuestraEstudiantes();

            formMuestraEstudiantes.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-CURSOS---------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            FormCreaCursos formCreaCursos = new FormCreaCursos();

            formCreaCursos.ShowDialog();
        }

        private void editarToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            FormEditaCursos formEditaCursos = new FormEditaCursos();

            formEditaCursos.ShowDialog();
        }

        private void eliminarToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            FormEliminaCursos formEliminaCursos = new FormEliminaCursos();

            formEliminaCursos.ShowDialog();
        }

        private void mostrarListaToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            FormMuestraCursos formMuestraCursos = new FormMuestraCursos();

            formMuestraCursos.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-PERIODOS------------------------ 
         ------------------------------------------------------------*/

        private void crearToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            FormCreaPeriodos formCreaPeriodos = new FormCreaPeriodos();

            formCreaPeriodos.ShowDialog();
        }

        private void editarToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            FormEditaPeriodos formEditaPeriodos = new FormEditaPeriodos();

            formEditaPeriodos.ShowDialog();
        }

        private void eliminarToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            FormEliminaPeriodos formEliminaPeriodos = new FormEliminaPeriodos();

            formEliminaPeriodos.ShowDialog();
        }

        private void mostrarListaToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            FormMuestraPeriodos formMuestraPeriodos = new FormMuestraPeriodos();

            formMuestraPeriodos.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-Matriculas---------------------- 
         ------------------------------------------------------------*/

        private void eliminarToolStripMenuMatriculas_Click(object sender, EventArgs e)
        {
            FormEliminaMatriculas formEliminaMatricula = new FormEliminaMatriculas();

            formEliminaMatricula.ShowDialog();
        }

        private void reporteToolStripMenuMatriculas_Click(object sender, EventArgs e)
        {
            FormGeneraReportes formGeneraReportes = new FormGeneraReportes();

            formGeneraReportes.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------METODOS-BUSCADOR------------------------ 
         ------------------------------------------------------------*/

        private void buscadorToolStripMenuHerramientas_Click(object sender, EventArgs e)
        {
            FormBuscador formBuscador = new FormBuscador();

            formBuscador.ShowDialog();
        }
    }
}
