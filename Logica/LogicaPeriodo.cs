using Npgsql;
using PracticaLaboratorio2.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaPeriodo
    {
        String instruccion, instruccionKey, instruccionPrincipal;
        DataTable dataTable;
        NpgsqlDataReader datosObtenidos;
        BindingSource regresa = new BindingSource();
        Conexion conexion = new Conexion();
        Boolean resultado = false;
        List<String> lista = new List<string>();

        public Boolean CrearPeriodo(String periodo)
        {
            instruccionKey = "select * from periodo where periodo = '" + periodo + "'";
            instruccionPrincipal = "insert into periodo values ('" + periodo + "')";
            
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
            instruccion = "update periodo set periodo = '" + periodoNuevo + "' where periodo = '" + periodoActual + "'";
            
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
            instruccion = "delete from periodo where periodo = '" + periodo + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaPeriodos()
        {
            instruccion = "select * from periodo";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public List<String> ObtenerPeriodos()
        {
            instruccion = "select * from periodo";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccion);

            while (datosObtenidos.Read())
            {
                lista.Add(datosObtenidos[0].ToString());
            }

            conexion.Desconectar();

            return lista;
        }

        public void VaciarListaPeriodos()
        {
            if (lista.Count > 0)
                lista.RemoveRange(1, lista.Count);
        }
    }
}
