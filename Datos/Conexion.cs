using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Datos
{
    class Conexion
    {
        private String urlConexion = "Server = 127.0.0.1; User Id = postgres; Password=123; Database=proyecto;";
        private NpgsqlConnection conexion;

        public Conexion()
        {
            conexion = new NpgsqlConnection(urlConexion);
        }

        public Boolean Conectar()
        {
            Boolean resultado = false;

            try 
            {
                conexion.Open();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al intentar conectarse a la base de datos", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        public Boolean Desconectar()
        {
            Boolean resultado = false;

            try
            {
                this.conexion.Close();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al intentar desconectarse de la base de datos", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        // Ejecuta Create, Update, Delete
        public Boolean EjecutarInstruccion(String instruccion)
        {
            Boolean resultado = false;
            int numColumnasAfectadas;
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(instruccion, conexion);
                numColumnasAfectadas = comando.ExecuteNonQuery();
                
                if (numColumnasAfectadas != -1)
                    resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al intentar ejecutar una instrucción en la base de datos", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        // Ejecuta Read
        public NpgsqlDataReader Leer(String instruccion)
        {
            NpgsqlDataReader readerRegresa = null;
            
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(instruccion, conexion);
                readerRegresa = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al intentar leer de la base de datos", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return readerRegresa;
        }

        public DataTable ObtenerDataTable(String instruccion) 
        {
            DataTable regresa = new DataTable();

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(instruccion, conexion);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(comando);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);
                regresa = ds.Tables[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error al intentar leer de la base de datos", "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return regresa;
        }
    }
}
