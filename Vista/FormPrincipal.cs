using PracticaLaboratorio2.Vista;
using System;
using System.Windows.Forms;

namespace PracticaLaboratorio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Boolean loginCorrecto = false;

            FormLogin FormularioLogin = new FormLogin();

            FormularioLogin.ShowDialog();

            loginCorrecto = FormularioLogin.loginCorrecto;

            if (loginCorrecto == false)
            {
                this.Close();
            }
        }
    }
}
