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
        DataTable dataTable;
        NpgsqlDataReader datosObtenidos;
        String instruccion, instruccionKey, instruccionPrincipal, instruccionSecundaria;
        Conexion conexion = new Conexion();
        BindingSource regresa = new BindingSource();
        Boolean resultado = false;

        public Usuario ValidarUsuario(Usuario usuario)
        {
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
            instruccionKey = "select perfil from usuario where usuario = '" + usuario.User + "'";
            instruccionPrincipal = "insert into usuario (usuario, clave, perfil) values ('" + usuario.User + "', '" + usuario.Clave + "', '" + usuario.Perfil + "')";

            if (usuario.User != "" && usuario.Clave != "" && usuario.Perfil != null)
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
            instruccion = "update usuario set usuario = '" + usuarioNuevo.User + "', clave = '" + usuarioNuevo.Clave + "', perfil = '" + usuarioNuevo.Perfil + "' where usuario = '" + usuarioActual.User + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
            {
                MessageBox.Show("Los datos se editaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado = true;
            }

            conexion.Desconectar();

            return resultado;
        }

        public void EditarUsuarioTablaEstudiante(Usuario usuarioActual, Usuario usuarioNuevo)
        {
            instruccion = "update estudiante set usuario = '" + usuarioNuevo.User +  "' where usuario = '" + usuarioActual.User + "'";

            conexion.Conectar();

            conexion.EjecutarInstruccion(instruccion);
            
            conexion.Desconectar();
        }

        public void EliminarUsuario(String usuario)
        {
            instruccion = "delete from usuario where usuario = '" + usuario + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }

        public BindingSource MostrarListaUsuarios()
        {
            instruccion = "select * from usuario where perfil = 'estudiante'";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public BindingSource MostrarUsuarioEspecífico(String usuario)
        {
            instruccion = "select * from usuario where perfil = 'estudiante' and usuario = '" + usuario + "'";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public Boolean RegistrarUsuario(Usuario usuario, String clave)
        {
            instruccionSecundaria = "select * from usuario where usuario = '" + usuario.User + "'";
            instruccionPrincipal = "insert into usuario (usuario, clave, perfil) values ('" + usuario.User + "', '" + usuario.Clave + "', '" + usuario.Perfil + "')";

            if (usuario.User != "" && usuario.Clave != "")
            {
                if (usuario.Clave == clave)
                {
                    conexion.Conectar();
                    datosObtenidos = conexion.Leer(instruccionSecundaria);

                    if (datosObtenidos.Read())
                        MessageBox.Show("El usuario ya existe", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        conexion.Desconectar();
                        conexion.Conectar();

                        if (conexion.EjecutarInstruccion(instruccionPrincipal))
                        {
                            MessageBox.Show("El usuario se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resultado = true;
                        }
                    }

                    conexion.Desconectar();
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, intentelo de nuevo", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return resultado;
        }

        public void RegistraUsuarioTablaEstudiante(Usuario usuario)
        {
            instruccion = "insert into estudiante (usuario) values ('" + usuario.User + "')";

            conexion.Conectar();

            conexion.EjecutarInstruccion(instruccion);
            
            conexion.Desconectar();
        }
    }
}
