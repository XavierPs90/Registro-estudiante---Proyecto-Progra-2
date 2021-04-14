using Npgsql;
using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaEstudiante
    {
        private Conexion conexion = new Conexion();
        public List<String> estudiante = new List<string>();
        private String usuario;

        public Boolean CrearEstudiante(Student estudiante, String usuario)
        {
            String instruccionKey, instruccionPrincipal;//, instruccionSecundaria;
            NpgsqlDataReader datosObtenidos;

            instruccionKey = "select cedula from estudiante where cedula = '" + estudiante.Cedula + "'";
            instruccionPrincipal = "insert into estudiante (cedula, nombre, edad, usuario)" + " values ('" + estudiante.Cedula + "', '" + estudiante.Nombre + "', '" + estudiante.Edad + "', '" + usuario + "')";
            //instruccionSecundaria = "insert into usuario (nombre)" + " values ('" + usuario + "')";
            Boolean resultado = false;
            
            if (estudiante.Cedula != "" && estudiante.Nombre != "" && estudiante.Edad != "")
            {
                conexion.Conectar();
                datosObtenidos = conexion.Leer(instruccionKey);
                //usuario = CargarUsuario();

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
                else
                    MessageBox.Show("El estudiante ya existe", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public Boolean EditarEstudiante(Student estudianteActual, Student estudianteNuevo) 
        {
            String instruccion = "update estudiante set cedula = '" + estudianteNuevo.Cedula + "', nombre = '" + estudianteNuevo.Nombre + "', edad = '" + estudianteNuevo.Edad + "' where cedula = '" + estudianteActual.Cedula + "'";
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

        public void EliminarEstudiante(String cedula)
        {
            String instruccion = "delete from estudiante where cedula = '" + cedula + "'";

            conexion.Conectar();
            
            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            conexion.Desconectar();
        }

        public BindingSource MostrarListaEstudiantes() 
        {
            BindingSource regresa = new BindingSource();
            DataTable dataTable;
            String instruccion = "select cedula, nombre, edad from estudiante";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public Boolean CargarEstudianteActual(String usuario) 
        {
            NpgsqlDataReader datosObtenidos;
            String instruccion = "select cedula, nombre, edad from estudiante where usuario = '" + usuario + "'";
            Boolean resultado;
            
            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccion);
            
            if (datosObtenidos.Read())
            {
                estudiante.Add(datosObtenidos[0].ToString());
                estudiante.Add(datosObtenidos[1].ToString());
                estudiante.Add(datosObtenidos[2].ToString());
                resultado = true;
            }
            else
                resultado = false;
            
            conexion.Desconectar();
            
            return resultado;
        }

        public Boolean CargarUsuario() 
        {
            NpgsqlDataReader datosObtenidos;
            String instruccion = "select usuario from estudiante where usuario = '" + usuario + "'";
            Boolean resultado;

            conexion.Conectar();
            datosObtenidos = conexion.Leer(instruccion);

            if (datosObtenidos.Read())
            {
                estudiante.Add(datosObtenidos[0].ToString());
                estudiante.Add(datosObtenidos[1].ToString());
                estudiante.Add(datosObtenidos[2].ToString());
                resultado = true;
            }
            else
                resultado = false;

            conexion.Desconectar();

            return false;
        }
    }
}
