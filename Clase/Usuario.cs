using System;

namespace PracticaLaboratorio2.Clase
{
    class Usuario
    {
        private String usuario, clave, perfil; 
        private Boolean loginCorrecto;

        public String User
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public String Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public Boolean LoginCorrecto
        {
            get { return loginCorrecto; }
            set { loginCorrecto = value; }
        }
    }
}
