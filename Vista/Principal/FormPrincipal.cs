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
        private FormCreaUsuarios formCreaUsuarios = new FormCreaUsuarios();
        private FormEditaUsuarios formEditaUsuarios = new FormEditaUsuarios();
        private FormEliminaUsuarios formEliminaUsuarios = new FormEliminaUsuarios();
        private FormMuestraUsuarios formMuestraUsuarios = new FormMuestraUsuarios();
        private FormCreaEstudiante formCreaEstudiante = new FormCreaEstudiante();
        private FormEditaEstudiantes formEditaEstudiantes = new FormEditaEstudiantes();
        private LogicaUsuario logicaUsuario = new LogicaUsuario();
        private FormEliminaEstudiantes formEliminaEstudiantes = new FormEliminaEstudiantes();
        private FormMuestraEstudiantes formMuestraEstudiantes = new FormMuestraEstudiantes();
        private FormCreaCursos formCreaCursos = new FormCreaCursos();
        private FormEditaCursos formEditaCursos = new FormEditaCursos();
        private FormEliminaCursos formEliminaCursos = new FormEliminaCursos();
        private FormMuestraCursos formMuestraCursos = new FormMuestraCursos();
        private FormCreaPeriodos formCreaPeriodos = new FormCreaPeriodos();
        private FormEditaPeriodos formEditaPeriodos = new FormEditaPeriodos();
        private FormEliminaPeriodos formEliminaPeriodos = new FormEliminaPeriodos();
        private FormMuestraPeriodos formMuestraPeriodos = new FormMuestraPeriodos();
        private FormCreaMatriculas formCreaMatriculas = new FormCreaMatriculas();
        private FormEliminaMatriculas formEliminaMatricula = new FormEliminaMatriculas();
        private FormGeneraReportes formGeneraReportes = new FormGeneraReportes();
        private FormBuscador formBuscador = new FormBuscador();

        public FormPrincipal()
        {
            InitializeComponent();
        }


        /*-------------------------------------------------------------
         *----------------------MENU-PRINCIPAL------------------------- 
         ------------------------------------------------------------*/

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            formLogin.ShowDialog();

            if (formLogin.LoginCorrecto == false)
            {
                Close();
            }

            VerificarPerfil();
        }

        private void VerificarPerfil()
        {
            if (formLogin.Perfil != "administrador")
            {
                // USUARIOS
                crearToolStripMenuUsuarios.Enabled = false;
                crearToolStripMenuUsuarios.Visible = false;
                eliminarToolStripMenuUsuarios.Enabled = false;
                eliminarToolStripMenuUsuarios.Visible = false;
                // ESTUDIANTES
                eliminarToolStripMenuEstudiantes.Enabled = false;
                eliminarToolStripMenuEstudiantes.Visible = false;
                // CURSOS
                crearToolStripMenuCursos.Enabled = false;
                crearToolStripMenuCursos.Visible = false;
                editarToolStripMenuCursos.Enabled = false;
                editarToolStripMenuCursos.Visible = false;
                eliminarToolStripMenuCursos.Enabled = false;
                eliminarToolStripMenuCursos.Visible = false;
                // PERIODOS
                crearToolStripMenuPeriodos.Enabled = false;
                crearToolStripMenuPeriodos.Visible = false;
                editarToolStripMenuPeriodos.Enabled = false;
                editarToolStripMenuPeriodos.Visible = false;
                eliminarToolStripMenuPeriodos.Enabled = false;
                eliminarToolStripMenuPeriodos.Visible = false;
                // MATRICULAS
                editarToolStripMenuMatriculas.Enabled = false;
                editarToolStripMenuMatriculas.Visible = false;
                // BUSCADOR
                herramientasToolStripMenu.Enabled = false;
                herramientasToolStripMenu.Visible = false;
            }
        }

        /*-------------------------------------------------------------
         *---------------------MENU-ARCHIVO---------------------------- 
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
         *---------------------MENU-USUARIOS--------------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            formCreaUsuarios.ShowDialog();
        }

        private void editarToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            if (formLogin.Perfil != "administrador")
            {
                formEditaUsuarios.User = formLogin.Usuario;
                formEditaUsuarios.Profile = formLogin.Perfil;
                formEditaUsuarios.ShowDialog();
                formLogin.Usuario = formEditaUsuarios.User;
            }
            else
            {
                formEditaUsuarios.Profile = formLogin.Perfil;
                formEditaUsuarios.ShowDialog();
            }
        }

        private void eliminarToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {
            formEliminaUsuarios.ShowDialog();
        }

        private void mostrarListaToolStripMenuUsuarios_Click(object sender, EventArgs e)
        {

            if (formEditaUsuarios.User == null)
                formMuestraUsuarios.Usuario = formLogin.Usuario;
            else 
                formMuestraUsuarios.Usuario = formEditaUsuarios.User;
            
            formMuestraUsuarios.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------MENU-ESTUDIANTES------------------------ 
         ------------------------------------------------------------*/

        private void crearToolStripMenuEstudiante_Click(object sender, EventArgs e)
        {
            if (formLogin.Perfil == "administrador")
                if (formCreaEstudiante.Usuario != null)
                {
                    formCreaEstudiante.Usuario = formCreaUsuarios.Usuario;
                    formCreaEstudiante.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Para crear un estudiante primero debe crear otro usuario y luego el estudiante", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
            {
                if (formCreaEstudiante.Usuario == null)
                {
                    formCreaEstudiante.Usuario = formLogin.Usuario;
                    formCreaEstudiante.ShowDialog();
                }
                else
                    MessageBox.Show("Este usuario ya tiene asignado un estudiante", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editarToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            if (formLogin.Perfil != "administrador")
            {
                formEditaEstudiantes.Usuario = formLogin.Usuario;
                formEditaEstudiantes.Perfil = formLogin.Perfil;
                formEditaEstudiantes.ShowDialog();
                formLogin.Usuario = formEditaEstudiantes.Usuario;
            }
            else
            {
                formEditaEstudiantes.Perfil = formLogin.Perfil;
                formEditaEstudiantes.ShowDialog();
            }
        }

        private void eliminarToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            formEliminaEstudiantes.ShowDialog();
        }

        private void mostrarListaToolStripMenuEstudiantes_Click(object sender, EventArgs e)
        {
            if (formLogin.Perfil != "administrador")
                formMuestraEstudiantes.Usuario = formLogin.Usuario;

            formMuestraEstudiantes.Perfil = formLogin.Perfil;
            formMuestraEstudiantes.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------MENU-CURSOS----------------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            formCreaCursos.ShowDialog();
        }

        private void editarToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            formEditaCursos.ShowDialog();
        }

        private void eliminarToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            formEliminaCursos.ShowDialog();
        }

        private void mostrarListaToolStripMenuCursos_Click(object sender, EventArgs e)
        {
            formMuestraCursos.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------MENU-PERIODOS--------------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            formCreaPeriodos.ShowDialog();
        }

        private void editarToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            formEditaPeriodos.ShowDialog();
        }

        private void eliminarToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            formEliminaPeriodos.ShowDialog();
        }

        private void mostrarListaToolStripMenuPeriodos_Click(object sender, EventArgs e)
        {
            formMuestraPeriodos.ShowDialog();
        }

        /*-------------------------------------------------------------
         *---------------------MENU-MATRICULAS------------------------- 
         ------------------------------------------------------------*/

        private void crearToolStripMenuIMatriculas_Click(object sender, EventArgs e)
        {
            if (formLogin.Usuario != "" && formCreaEstudiante.Usuario != "")
            {
                if (formCreaMatriculas.Perfil == "administrador")
                    formCreaMatriculas.Usuario = formCreaEstudiante.Usuario;
                else
                    formCreaMatriculas.Usuario = formLogin.Usuario;

                formCreaMatriculas.ShowDialog();
            }
            else
                MessageBox.Show("Primero debe crear un usuario y un estudiante para realizar la matricula ", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*-------------------------------------------------------------
         *---------------------MENU-BUSCADOR--------------------------- 
         ------------------------------------------------------------*/

        private void buscadorToolStripMenuHerramientas_Click(object sender, EventArgs e)
        {
            formBuscador.ShowDialog();
        }


    }
}
