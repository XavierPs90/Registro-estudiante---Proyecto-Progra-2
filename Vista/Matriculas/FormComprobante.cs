using PracticaLaboratorio2.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PracticaLaboratorio2.Vista.Matriculas
{
    public partial class FormComprobante : Form
    {
        private int lineasImpresas;
        private String[] lineas;
        private String usuario, cedula, nombre, periodo;
        public List<String> cursos = new List<String>();
        private LogicaMatricula logicaMatricula = new LogicaMatricula();

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

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

        public String Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public FormComprobante()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormComprobante_Load(object sender, EventArgs e)
        {
            FormCreaMatriculas formCreaMatriculas = new FormCreaMatriculas();

            logicaMatricula.CargarComprobante(usuario, cedula, nombre, periodo, cursos);
            richTextBox1.Lines = logicaMatricula.Comprobante;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog1.PrinterSettings.PrintRange == PrintRange.Selection) 
            {
                lineas = richTextBox1.SelectedText.Split(param);
            }
            else 
            {
                lineas = richTextBox1.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            
            foreach (String s in lineas)
            {
                lineas[i++] = s.TrimEnd(trimParam);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(richTextBox1.ForeColor);

            while (lineasImpresas < lineas.Length)
            {
                e.Graphics.DrawString(lineas[lineasImpresas++], richTextBox1.Font, brush, x, y);
                y += 15;

                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            lineasImpresas = 0;
            e.HasMorePages = false;
        }
    }
}
