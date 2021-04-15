
namespace PracticaLaboratorio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuIArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuIEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuMatriculas = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuMatriculas = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuMatriculas = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorToolStripMenuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenu,
            this.usuariosToolStripMenu,
            this.estudiantesToolStripMenu,
            this.cursosToolStripMenu,
            this.periodosToolStripMenu,
            this.matrículasToolStripMenu,
            this.herramientasToolStripMenu});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(616, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "Menú Principal";
            // 
            // archivoToolStripMenu
            // 
            this.archivoToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuArchivo,
            this.salirToolStripMenuIArchivo});
            this.archivoToolStripMenu.Name = "archivoToolStripMenu";
            this.archivoToolStripMenu.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenu.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuArchivo
            // 
            this.cerrarSesiónToolStripMenuArchivo.Name = "cerrarSesiónToolStripMenuArchivo";
            this.cerrarSesiónToolStripMenuArchivo.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuArchivo.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuArchivo.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuArchivo_Click);
            // 
            // salirToolStripMenuIArchivo
            // 
            this.salirToolStripMenuIArchivo.Name = "salirToolStripMenuIArchivo";
            this.salirToolStripMenuIArchivo.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuIArchivo.Text = "Salir";
            this.salirToolStripMenuIArchivo.Click += new System.EventHandler(this.salirToolStripMenuArchivo_Click);
            // 
            // usuariosToolStripMenu
            // 
            this.usuariosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuUsuarios,
            this.editarToolStripMenuUsuarios,
            this.eliminarToolStripMenuUsuarios,
            this.mostrarListaToolStripMenuUsuarios});
            this.usuariosToolStripMenu.Name = "usuariosToolStripMenu";
            this.usuariosToolStripMenu.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenu.Text = "Usuarios";
            // 
            // crearToolStripMenuUsuarios
            // 
            this.crearToolStripMenuUsuarios.Name = "crearToolStripMenuUsuarios";
            this.crearToolStripMenuUsuarios.Size = new System.Drawing.Size(142, 22);
            this.crearToolStripMenuUsuarios.Text = "Crear";
            this.crearToolStripMenuUsuarios.Click += new System.EventHandler(this.crearToolStripMenuUsuarios_Click);
            // 
            // editarToolStripMenuUsuarios
            // 
            this.editarToolStripMenuUsuarios.Name = "editarToolStripMenuUsuarios";
            this.editarToolStripMenuUsuarios.Size = new System.Drawing.Size(142, 22);
            this.editarToolStripMenuUsuarios.Text = "Editar";
            this.editarToolStripMenuUsuarios.Click += new System.EventHandler(this.editarToolStripMenuUsuarios_Click);
            // 
            // eliminarToolStripMenuUsuarios
            // 
            this.eliminarToolStripMenuUsuarios.Name = "eliminarToolStripMenuUsuarios";
            this.eliminarToolStripMenuUsuarios.Size = new System.Drawing.Size(142, 22);
            this.eliminarToolStripMenuUsuarios.Text = "Eliminar";
            this.eliminarToolStripMenuUsuarios.Click += new System.EventHandler(this.eliminarToolStripMenuUsuarios_Click);
            // 
            // mostrarListaToolStripMenuUsuarios
            // 
            this.mostrarListaToolStripMenuUsuarios.Name = "mostrarListaToolStripMenuUsuarios";
            this.mostrarListaToolStripMenuUsuarios.Size = new System.Drawing.Size(142, 22);
            this.mostrarListaToolStripMenuUsuarios.Text = "Mostrar Lista";
            this.mostrarListaToolStripMenuUsuarios.Click += new System.EventHandler(this.mostrarListaToolStripMenuUsuarios_Click);
            // 
            // estudiantesToolStripMenu
            // 
            this.estudiantesToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuEstudiantes,
            this.editarToolStripMenuIEstudiantes,
            this.eliminarToolStripMenuEstudiantes,
            this.mostrarListaToolStripMenuEstudiantes});
            this.estudiantesToolStripMenu.Name = "estudiantesToolStripMenu";
            this.estudiantesToolStripMenu.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenu.Text = "Estudiantes";
            // 
            // crearToolStripMenuEstudiantes
            // 
            this.crearToolStripMenuEstudiantes.Name = "crearToolStripMenuEstudiantes";
            this.crearToolStripMenuEstudiantes.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuEstudiantes.Text = "Crear";
            this.crearToolStripMenuEstudiantes.Click += new System.EventHandler(this.crearToolStripMenuEstudiante_Click);
            // 
            // editarToolStripMenuIEstudiantes
            // 
            this.editarToolStripMenuIEstudiantes.Name = "editarToolStripMenuIEstudiantes";
            this.editarToolStripMenuIEstudiantes.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuIEstudiantes.Text = "Editar";
            this.editarToolStripMenuIEstudiantes.Click += new System.EventHandler(this.editarToolStripMenuEstudiantes_Click);
            // 
            // eliminarToolStripMenuEstudiantes
            // 
            this.eliminarToolStripMenuEstudiantes.Name = "eliminarToolStripMenuEstudiantes";
            this.eliminarToolStripMenuEstudiantes.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuEstudiantes.Text = "Eliminar";
            this.eliminarToolStripMenuEstudiantes.Click += new System.EventHandler(this.eliminarToolStripMenuEstudiantes_Click);
            // 
            // mostrarListaToolStripMenuEstudiantes
            // 
            this.mostrarListaToolStripMenuEstudiantes.Name = "mostrarListaToolStripMenuEstudiantes";
            this.mostrarListaToolStripMenuEstudiantes.Size = new System.Drawing.Size(180, 22);
            this.mostrarListaToolStripMenuEstudiantes.Text = "Mostrar lista";
            this.mostrarListaToolStripMenuEstudiantes.Click += new System.EventHandler(this.mostrarListaToolStripMenuEstudiantes_Click);
            // 
            // cursosToolStripMenu
            // 
            this.cursosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuCursos,
            this.editarToolStripMenuCursos,
            this.eliminarToolStripMenuCursos,
            this.mostrarListaToolStripMenuCursos});
            this.cursosToolStripMenu.Name = "cursosToolStripMenu";
            this.cursosToolStripMenu.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenu.Text = "Cursos";
            // 
            // crearToolStripMenuCursos
            // 
            this.crearToolStripMenuCursos.Name = "crearToolStripMenuCursos";
            this.crearToolStripMenuCursos.Size = new System.Drawing.Size(139, 22);
            this.crearToolStripMenuCursos.Text = "Crear";
            this.crearToolStripMenuCursos.Click += new System.EventHandler(this.crearToolStripMenuCursos_Click);
            // 
            // editarToolStripMenuCursos
            // 
            this.editarToolStripMenuCursos.Name = "editarToolStripMenuCursos";
            this.editarToolStripMenuCursos.Size = new System.Drawing.Size(139, 22);
            this.editarToolStripMenuCursos.Text = "Editar";
            this.editarToolStripMenuCursos.Click += new System.EventHandler(this.editarToolStripMenuCursos_Click);
            // 
            // eliminarToolStripMenuCursos
            // 
            this.eliminarToolStripMenuCursos.Name = "eliminarToolStripMenuCursos";
            this.eliminarToolStripMenuCursos.Size = new System.Drawing.Size(139, 22);
            this.eliminarToolStripMenuCursos.Text = "Eliminar";
            this.eliminarToolStripMenuCursos.Click += new System.EventHandler(this.eliminarToolStripMenuCursos_Click);
            // 
            // mostrarListaToolStripMenuCursos
            // 
            this.mostrarListaToolStripMenuCursos.Name = "mostrarListaToolStripMenuCursos";
            this.mostrarListaToolStripMenuCursos.Size = new System.Drawing.Size(139, 22);
            this.mostrarListaToolStripMenuCursos.Text = "Mostrar lista";
            this.mostrarListaToolStripMenuCursos.Click += new System.EventHandler(this.mostrarListaToolStripMenuCursos_Click);
            // 
            // periodosToolStripMenu
            // 
            this.periodosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuPeriodos,
            this.editarToolStripMenuPeriodos,
            this.eliminarToolStripMenuPeriodos,
            this.mostrarListaToolStripMenuPeriodos});
            this.periodosToolStripMenu.Name = "periodosToolStripMenu";
            this.periodosToolStripMenu.Size = new System.Drawing.Size(65, 20);
            this.periodosToolStripMenu.Text = "Periodos";
            // 
            // crearToolStripMenuPeriodos
            // 
            this.crearToolStripMenuPeriodos.Name = "crearToolStripMenuPeriodos";
            this.crearToolStripMenuPeriodos.Size = new System.Drawing.Size(139, 22);
            this.crearToolStripMenuPeriodos.Text = "Crear";
            this.crearToolStripMenuPeriodos.Click += new System.EventHandler(this.crearToolStripMenuPeriodos_Click);
            // 
            // editarToolStripMenuPeriodos
            // 
            this.editarToolStripMenuPeriodos.Name = "editarToolStripMenuPeriodos";
            this.editarToolStripMenuPeriodos.Size = new System.Drawing.Size(139, 22);
            this.editarToolStripMenuPeriodos.Text = "Editar";
            this.editarToolStripMenuPeriodos.Click += new System.EventHandler(this.editarToolStripMenuPeriodos_Click);
            // 
            // eliminarToolStripMenuPeriodos
            // 
            this.eliminarToolStripMenuPeriodos.Name = "eliminarToolStripMenuPeriodos";
            this.eliminarToolStripMenuPeriodos.Size = new System.Drawing.Size(139, 22);
            this.eliminarToolStripMenuPeriodos.Text = "Eliminar";
            this.eliminarToolStripMenuPeriodos.Click += new System.EventHandler(this.eliminarToolStripMenuPeriodos_Click);
            // 
            // mostrarListaToolStripMenuPeriodos
            // 
            this.mostrarListaToolStripMenuPeriodos.Name = "mostrarListaToolStripMenuPeriodos";
            this.mostrarListaToolStripMenuPeriodos.Size = new System.Drawing.Size(139, 22);
            this.mostrarListaToolStripMenuPeriodos.Text = "Mostrar lista";
            this.mostrarListaToolStripMenuPeriodos.Click += new System.EventHandler(this.mostrarListaToolStripMenuPeriodos_Click);
            // 
            // matrículasToolStripMenu
            // 
            this.matrículasToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuMatriculas,
            this.eliminarToolStripMenuMatriculas,
            this.reporteToolStripMenuMatriculas});
            this.matrículasToolStripMenu.Name = "matrículasToolStripMenu";
            this.matrículasToolStripMenu.Size = new System.Drawing.Size(69, 20);
            this.matrículasToolStripMenu.Text = "Matrícula";
            // 
            // editarToolStripMenuMatriculas
            // 
            this.editarToolStripMenuMatriculas.Name = "editarToolStripMenuMatriculas";
            this.editarToolStripMenuMatriculas.Size = new System.Drawing.Size(156, 22);
            this.editarToolStripMenuMatriculas.Text = "Editar";
            // 
            // eliminarToolStripMenuMatriculas
            // 
            this.eliminarToolStripMenuMatriculas.Name = "eliminarToolStripMenuMatriculas";
            this.eliminarToolStripMenuMatriculas.Size = new System.Drawing.Size(156, 22);
            this.eliminarToolStripMenuMatriculas.Text = "Eliminar";
            this.eliminarToolStripMenuMatriculas.Click += new System.EventHandler(this.eliminarToolStripMenuMatriculas_Click);
            // 
            // reporteToolStripMenuMatriculas
            // 
            this.reporteToolStripMenuMatriculas.Name = "reporteToolStripMenuMatriculas";
            this.reporteToolStripMenuMatriculas.Size = new System.Drawing.Size(156, 22);
            this.reporteToolStripMenuMatriculas.Text = "Generar reporte";
            this.reporteToolStripMenuMatriculas.Click += new System.EventHandler(this.reporteToolStripMenuMatriculas_Click);
            // 
            // herramientasToolStripMenu
            // 
            this.herramientasToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscadorToolStripMenuHerramientas});
            this.herramientasToolStripMenu.Name = "herramientasToolStripMenu";
            this.herramientasToolStripMenu.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenu.Text = "Herramientas";
            // 
            // buscadorToolStripMenuHerramientas
            // 
            this.buscadorToolStripMenuHerramientas.Name = "buscadorToolStripMenuHerramientas";
            this.buscadorToolStripMenuHerramientas.Size = new System.Drawing.Size(123, 22);
            this.buscadorToolStripMenuHerramientas.Text = "Buscador";
            this.buscadorToolStripMenuHerramientas.Click += new System.EventHandler(this.buscadorToolStripMenuHerramientas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticaLaboratorio2.Properties.Resources.fondo_principal;
            this.ClientSize = new System.Drawing.Size(616, 556);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de registro de estudiantes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuIArchivo;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem matrículasToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem buscadorToolStripMenuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuIEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuCursos;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuMatriculas;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuMatriculas;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuMatriculas;
    }
}

