using Npgsql;
using PracticaLaboratorio2.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaCurso
    {
        String instruccion, instruccionKey, instruccionPrincipal;
        NpgsqlDataReader datosObtenidos;
        DataTable dataTable;
        Conexion conexion = new Conexion();
        Boolean resultado = false;
        List<String> lista = new List<string>();
        
        public Boolean CrearCurso(String curso)
        {
            instruccionKey = "select * from curso where curso = '" + curso + "'";
            instruccionPrincipal = "insert into curso values ('" + curso + "')";
            
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
            instruccion = "update curso set curso = '" + cursoNuevo + "' where curso = '" + cursoActual + "'";
            
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
            instruccion = "delete from curso where curso = '" + curso + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaCursos()
        {
            BindingSource regresa = new BindingSource();
            instruccion = "select * from curso";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public List<String> ObtenerCursos() 
        {
            instruccion = "select * from curso";

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccion);

            while (datosObtenidos.Read())
            {
                    lista.Add(datosObtenidos[0].ToString());
            }

            conexion.Desconectar();

            return lista;
        }

        public void VaciarListaCursos() 
        {
            if (lista.Count > 0)
                lista.RemoveRange(1, lista.Count);
        }
    }
}
