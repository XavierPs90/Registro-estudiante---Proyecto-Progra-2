using Npgsql;
using PracticaLaboratorio2.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaMatricula
    {
        private int numeroComprobante;
        private String instruccion, instruccionKey, instruccionPrincipal, instruccionSecundaria, usuarioMatricula;
        private String[] comprobante; 
        private DateTime fecha_matricula;
        private NpgsqlDataReader datosObtenidos;
        private Boolean resultado = false;
        DataTable dataTable;
        private Conexion conexion = new Conexion();
        BindingSource regresa = new BindingSource();
        private LogicaCurso logicaCurso = new LogicaCurso();
        private LogicaPeriodo logicaPeriodo = new LogicaPeriodo();

        public String[] Comprobante
        {
            get { return comprobante; }
            set { comprobante = value; }
        }

        public Boolean CrearMatricula(String usuario, String periodo)
        {
            fecha_matricula = DateTime.Now;
            instruccionKey = "select usuario from matricula where usuario = '" + usuario + "'";
            instruccionPrincipal = "insert into matricula (usuario, periodo, fecha_matricula)"
                                    + " values ('" + usuario + "', '" + periodo + "', '" + fecha_matricula + "')";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccionKey);

            if (!datosObtenidos.Read())
            {
                conexion.Desconectar();
                conexion.Conectar();

                if (conexion.EjecutarInstruccion(instruccionPrincipal))
                {
                    resultado = true;
                    MessageBox.Show("El estudiante se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            conexion.Desconectar();

            return resultado;
        }

        public Boolean AsignarCursos(String usuario, String curso)
        {
            instruccionKey = "select usuario from cursosxestudiante where usuario = '" + usuario + "' and curso = '" + curso + "'";
            instruccionPrincipal = "insert into cursosxestudiante (usuario, curso)"
                                    + " values ('" + usuario + "', '" + curso + "')";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccionKey);

            if (!datosObtenidos.Read())
            {
                conexion.Desconectar();
                conexion.Conectar();

                if (conexion.EjecutarInstruccion(instruccionPrincipal))
                {
                    resultado = true;
                }
            }
            else
                MessageBox.Show("Ya existe una matricula registrada a este estudiante, no se puede matricular más de una vez", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();

            return resultado;
        }

        public void VaciarListas()
        {
            logicaCurso.VaciarListaCursos();
            logicaPeriodo.VaciarListaPeriodos();
        }

        public void CargarComprobante(String usuario, String cedula, String estudiante, String periodo, List<String> cursos)
        {
            ObtenerNumeroComprobante(usuario);
            int indice = cursos.Count + 16;
            fecha_matricula = DateTime.Now;
            comprobante = new String[indice];
            
            comprobante[0] = "Comprobante de matricula";
            comprobante[1] = "";
            comprobante[2] = "Fecha de matrícula: " + fecha_matricula; 
            comprobante[3] = "";
            comprobante[4] = "Número de comprobante: mat-" + numeroComprobante + "-2021";
            comprobante[5] = "";
            comprobante[6] = "Número de cédula: " + cedula;
            comprobante[7] = "";
            comprobante[8] = "Nombre del estudiante: "  + estudiante;
            comprobante[9] = "";
            comprobante[10] = "Periodo matriculado: " + periodo;
            comprobante[11] = "";
            comprobante[12] = "Cursos matriculados: ";
            
            int i = 14;
            foreach (String curso in cursos)
            {
                comprobante[i] = "                                   - " + curso;
                comprobante[i + 1] = "";
                i += 2;
            }
        }

        public void ObtenerNumeroComprobante(String usuario) 
        {
            instruccionKey = "select cod from matricula where usuario = '" + usuario + "'";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccionKey);

            if (datosObtenidos.Read())
            {
                numeroComprobante = (int)datosObtenidos[0];
            }
            
            conexion.Desconectar();
        }

        public BindingSource MostrarListaMatriculas()
        {
            instruccion = "select cedula, nombre, edad, periodo, fecha_matricula, cod from estudiante inner join matricula on estudiante.usuario = matricula.usuario";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public void EliminarMatriculas(String usuario)
        {
            instruccionPrincipal = "delete from matricula where usuario = '" + usuario + "'";
            instruccionSecundaria = "delete from cursosxestudiante where usuario = '" + usuario + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccionPrincipal) && conexion.EjecutarInstruccion(instruccionSecundaria))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public String CargarUsuarioMatricula(String cedula) 
        {
            instruccion = "select usuario from estudiante where cedula = '" + cedula + "'";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccion);
            
            if (datosObtenidos.Read())
            {
                usuarioMatricula = datosObtenidos[0].ToString();
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            conexion.Desconectar();

            return usuarioMatricula;
        }
    }
}
