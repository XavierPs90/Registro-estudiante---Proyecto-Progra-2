using Npgsql;
using PracticaLaboratorio2.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaPeriodo
    {
        Conexion conexion = new Conexion();

        public Boolean CrearPeriodo(String periodo)
        {
            String instruccionKey, instruccionPrincipal;
            NpgsqlDataReader datosObtenidos;

            instruccionKey = "select * from periodo where periodo = '" + periodo + "'";
            instruccionPrincipal = "insert into periodo values ('" + periodo + "')";
            Boolean resultado = false;

            if (periodo != "")
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
                        MessageBox.Show("El periodo se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("El periodo ya exite", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public Boolean EditarPeriodo(String periodoActual, String periodoNuevo)
        {
            String instruccion = "update periodo set periodo = '" + periodoNuevo + "' where periodo = '" + periodoActual + "'";
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

        public void EliminarPeriodo(String periodo)
        {
            String instruccion = "delete from periodo where periodo = '" + periodo + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaPeriodos()
        {
            BindingSource regresa = new BindingSource();
            DataTable dataTable;
            String instruccion = "select * from periodo";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }
    }
}
