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
        String instruccion, instruccionKey, instruccionPrincipal;
        NpgsqlDataReader datosObtenidos;
        DataTable dataTable;
        BindingSource regresa = new BindingSource();
        private Conexion conexion = new Conexion();
        public List<String> estudiante = new List<string>();
        Boolean resultado = false;

        public Boolean CrearEstudiante(Student estudiante)
        {
            instruccionKey = "select cedula from estudiante where cedula = '" + estudiante.Cedula + "'";
            instruccionPrincipal = "update estudiante set cedula = '" + estudiante.Cedula + "', nombre = '" + estudiante.Nombre + "', edad = '" 
                                    + estudiante.Edad + "' where usuario = '" + estudiante.Usuario + "'";

            if (estudiante.Cedula != "" && estudiante.Nombre != "" && estudiante.Edad != "")
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
                        MessageBox.Show("El estudiante se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Este usuario ya tiene asignado un estudiante", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public Boolean CrearEstudiantes(Student estudiante)
        {
            instruccionKey = "select cedula from estudiante where cedula = '" + estudiante.Cedula + "'";
            instruccionPrincipal = "insert into estudiante (cedula, nombre, edad, usuario) values ('" + estudiante.Cedula + "', '" + estudiante.Nombre + "', '"
                                    + estudiante.Edad + "', '" + estudiante.Usuario + "')";

            if (estudiante.Cedula != "" && estudiante.Nombre != "" && estudiante.Edad != "")
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
                        MessageBox.Show("El estudiante se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Este usuario ya tiene asignado un estudiante", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public Boolean EditarEstudiante(Student estudianteActual, Student estudianteNuevo)
        {
            instruccion = "update estudiante set cedula = '" + estudianteNuevo.Cedula + "', nombre = '" + estudianteNuevo.Nombre + "', edad = '" 
                        + estudianteNuevo.Edad + "' where usuario = '" + estudianteNuevo.Usuario + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
            {
                MessageBox.Show("Los datos se editaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado = true;
            }

            conexion.Desconectar();

            return resultado;
        }

        public Boolean EditarEstudiantes(Student estudianteActual, Student estudianteNuevo)
        {
            instruccion = "update estudiante set cedula = '" + estudianteNuevo.Cedula + "', nombre = '" + estudianteNuevo.Nombre + "', edad = '"
                        + estudianteNuevo.Edad + "' where cedula = '" + estudianteActual.Cedula + "'";

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
            instruccion = "delete from estudiante where cedula = '" + cedula + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaEstudiantes()
        {
            instruccion = "select cedula, nombre, edad from estudiante";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public BindingSource MostrarEstudianteEspecífico(String usuario)
        {
            instruccion = "select cedula, nombre, edad from estudiante where usuario = '" + usuario + "'";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public Boolean CargarEstudianteActual(String usuario)
        {
            instruccion = "select cedula, nombre, edad from estudiante where usuario = '" + usuario + "'";

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

        public Boolean CargarUsuario(String usuario)
        {
            instruccion = "select usuario from estudiante where usuario = '" + usuario + "'";

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
    }
}
