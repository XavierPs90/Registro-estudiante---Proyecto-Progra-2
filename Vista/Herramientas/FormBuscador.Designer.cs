
namespace PracticaLaboratorio2.Vista.Herramientas
{
    partial class FormBuscador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxCedula = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxEdad = new System.Windows.Forms.CheckBox();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.checkBoxCurso = new System.Windows.Forms.CheckBox();
            this.checkBoxPeriodo = new System.Windows.Forms.CheckBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDescripcionTipo = new System.Windows.Forms.Label();
            this.lblDescripciónPalabra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCedula
            // 
            this.checkBoxCedula.AutoSize = true;
            this.checkBoxCedula.Location = new System.Drawing.Point(71, 101);
            this.checkBoxCedula.Name = "checkBoxCedula";
            this.checkBoxCedula.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCedula.TabIndex = 0;
            this.checkBoxCedula.Text = "Cedula";
            this.checkBoxCedula.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Location = new System.Drawing.Point(146, 101);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(63, 17);
            this.checkBoxNombre.TabIndex = 1;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdad
            // 
            this.checkBoxEdad.AutoSize = true;
            this.checkBoxEdad.Location = new System.Drawing.Point(228, 101);
            this.checkBoxEdad.Name = "checkBoxEdad";
            this.checkBoxEdad.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEdad.TabIndex = 2;
            this.checkBoxEdad.Text = "Edad";
            this.checkBoxEdad.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(296, 101);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(62, 17);
            this.checkBoxUsuario.TabIndex = 3;
            this.checkBoxUsuario.Text = "Matricula";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurso
            // 
            this.checkBoxCurso.AutoSize = true;
            this.checkBoxCurso.Location = new System.Drawing.Point(375, 101);
            this.checkBoxCurso.Name = "checkBoxCurso";
            this.checkBoxCurso.Size = new System.Drawing.Size(53, 17);
            this.checkBoxCurso.TabIndex = 4;
            this.checkBoxCurso.Text = "Curso";
            this.checkBoxCurso.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeriodo
            // 
            this.checkBoxPeriodo.AutoSize = true;
            this.checkBoxPeriodo.Location = new System.Drawing.Point(445, 101);
            this.checkBoxPeriodo.Name = "checkBoxPeriodo";
            this.checkBoxPeriodo.Size = new System.Drawing.Size(62, 17);
            this.checkBoxPeriodo.TabIndex = 5;
            this.checkBoxPeriodo.Text = "Periodo";
            this.checkBoxPeriodo.UseVisualStyleBackColor = true;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Location = new System.Drawing.Point(524, 101);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(116, 17);
            this.checkBoxFecha.TabIndex = 6;
            this.checkBoxFecha.Text = "Fecha de matricula";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblDescripcionTipo
            // 
            this.lblDescripcionTipo.AutoSize = true;
            this.lblDescripcionTipo.Location = new System.Drawing.Point(68, 54);
            this.lblDescripcionTipo.Name = "lblDescripcionTipo";
            this.lblDescripcionTipo.Size = new System.Drawing.Size(61, 13);
            this.lblDescripcionTipo.TabIndex = 8;
            this.lblDescripcionTipo.Text = "Buscar por:";
            // 
            // lblDescripciónPalabra
            // 
            this.lblDescripciónPalabra.AutoSize = true;
            this.lblDescripciónPalabra.Location = new System.Drawing.Point(293, 54);
            this.lblDescripciónPalabra.Name = "lblDescripciónPalabra";
            this.lblDescripciónPalabra.Size = new System.Drawing.Size(75, 13);
            this.lblDescripciónPalabra.TabIndex = 9;
            this.lblDescripciónPalabra.Text = "Palabra clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(565, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(39, 124);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(649, 235);
            this.dataGridViewEstudiantes.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(445, 385);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 39);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(168, 385);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 39);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FormBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescripciónPalabra);
            this.Controls.Add(this.lblDescripcionTipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.checkBoxPeriodo);
            this.Controls.Add(this.checkBoxCurso);
            this.Controls.Add(this.checkBoxUsuario);
            this.Controls.Add(this.checkBoxEdad);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.checkBoxCedula);
            this.Name = "FormBuscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de registro de estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCedula;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxEdad;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.CheckBox checkBoxCurso;
        private System.Windows.Forms.CheckBox checkBoxPeriodo;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDescripcionTipo;
        private System.Windows.Forms.Label lblDescripciónPalabra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizar;
    }
}