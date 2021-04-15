using Npgsql;
using PracticaLaboratorio2.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaCurso
    {
        Conexion conexion = new Conexion();

        public Boolean CrearCurso(String curso)
        {
            String instruccionKey, instruccionPrincipal;
            NpgsqlDataReader datosObtenidos;

            instruccionKey = "select * from curso where curso = '" + curso + "'";
            instruccionPrincipal = "insert into curso values ('" + curso + "')";
            Boolean resultado = false;

            if (curso != "")
            {
                conexion.Conectar();
                datosObtenidos = conexion.Leer(instruccionKey);

                if (!datosObtenidos.Read())
                {
                    conexion.Desconectar();
                    conexion.Conectar();

                    if (conexion.EjecutarInstruccion(instruccionPrincipal))
                    {
                        resultado = true;
                        MessageBox.Show("El curso se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("El curso ya exite", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public Boolean EditarCursos(String cursoActual, String cursoNuevo)
        {
            String instruccion = "update curso set curso = '" + cursoNuevo + "' where curso = '" + cursoActual + "'";
            Boolean resultado = false;

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
            {
                MessageBox.Show("Los datos se editaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado = true;
            }

            conexion.Desconectar();

            return resultado;
        }

        public void EliminarCurso(String curso)
        {
            String instruccion = "delete from curso where curso = '" + curso + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaCursos()
        {
            BindingSource regresa = new BindingSource();
            DataTable dataTable;
            String instruccion = "select * from curso";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }
    }
}
