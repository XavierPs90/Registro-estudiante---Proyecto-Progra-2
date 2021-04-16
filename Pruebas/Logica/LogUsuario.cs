using Npgsql;
using PracticaLaboratorio2.Clase;
using PracticaLaboratorio2.Datos;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Pruebas.Logica
{
    
    class LogUsuario
    {
        Conexion conexion = new Conexion();

        public void RegistrarUsuario(Usuario usuario, String clave)
        {
            String instruccionSecundaria, instruccionPrincipal;
            NpgsqlDataReader datosObtenidos;

            instruccionSecundaria = "select * from usuario where usuario = '" + usuario.User + "' and clave = '" + usuario.Clave + "'";
            instruccionPrincipal = "select f_insertar_tabla_usuario ('" + usuario.User + "', '" + usuario.Clave + "', '" + usuario.Perfil + "')";

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
                        }
                    }
                    
                    conexion.Desconectar();
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, intentelo de nuevo", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
