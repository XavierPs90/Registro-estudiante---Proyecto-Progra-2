using Npgsql;
using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Logica
{
    class LogicaUsuario
    {
        Conexion conexion = new Conexion();

        public Usuario ValidarUsuario(Usuario usuario)
        {
            NpgsqlDataReader datosObtenidos;
            String instruccion;

            instruccion = "select perfil from usuario where usuario = '" + usuario.User + "' and clave = '" + usuario.Clave + "'";


            if (usuario.User == "" || usuario.Clave == "")
            {
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conexion.Conectar();
                datosObtenidos = conexion.Leer(instruccion);

                if (datosObtenidos.Read())
                {
                    usuario.Perfil = datosObtenidos[0].ToString();
                    usuario.LoginCorrecto = true;
                }
                else
                    MessageBox.Show("Los datos ingresados son incorrectos", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }

            return usuario;
        }

        public Boolean CrearUsuario(Usuario usuario) 
        {
            String instruccionKey, instruccionPrincipal;
            NpgsqlDataReader datosObtenidos;

            instruccionKey = "select perfil from usuario where usuario = '" + usuario.User + "'";
            instruccionPrincipal = "insert into usuario (usuario, clave, perfil) values ('" + usuario.User + "', '" + usuario.Clave + "', '" + usuario.Perfil + "')";
            Boolean resultado = false;
            
            if (usuario.User != "" && usuario.Clave != "" && usuario.Perfil != "") 
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
                        MessageBox.Show("El usuario se guardó correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("El usuario ya existe", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }
        
        public Boolean EditarUsuario(Usuario usuarioActual, Usuario usuarioNuevo)
        {
            String instruccion = "update usuario set usuario = '" + usuarioNuevo.User + "', clave = '" + usuarioNuevo.Clave + "', perfil = '" + usuarioNuevo.Perfil + "' where usuario = '" + usuarioActual.User + "'";
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
        
        public void EliminarUsuario(String usuario)
        {
            String instruccion = "delete from usuario where usuario = '" + usuario + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            conexion.Desconectar();
        }

        public BindingSource MostrarListaUsuarios()
        {
            BindingSource regresa = new BindingSource();
            DataTable dataTable;
            String instruccion = "select usuario, clave, perfil from usuario";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public String CargarNombre(String usuario) 
        {
            NpgsqlDataReader datosObtenidos;
            String instruccion, resultado = "";

            instruccion = "select nombre from usuario where usuario = '" + usuario + "'";

            {
                conexion.Conectar();
                datosObtenidos = conexion.Leer(instruccion);

                if (datosObtenidos.Read())
                {
                    resultado = datosObtenidos[0].ToString();
                }
                else
                    MessageBox.Show("Aún no existe un perfil de estudiante para editar", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Desconectar();
            }

            return resultado;
        }
    }
}
