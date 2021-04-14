using System;

namespace PracticaLaboratorio2.Clase
{
    class Student
    {
        private String cedula, nombre, edad, usuario;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
