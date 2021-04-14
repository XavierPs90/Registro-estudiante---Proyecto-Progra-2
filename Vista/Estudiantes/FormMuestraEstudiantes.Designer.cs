
namespace PracticaLaboratorio2.Vista.Estudiantes
{
    partial class FormMuestraEstudiantes
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
            this.dGVMuestraListaEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMuestraListaEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMuestraListaEstudiantes
            // 
            this.dGVMuestraListaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMuestraListaEstudiantes.Location = new System.Drawing.Point(30, 32);
            this.dGVMuestraListaEstudiantes.Name = "dGVMuestraListaEstudiantes";
            this.dGVMuestraListaEstudiantes.Size = new System.Drawing.Size(341, 173);
            this.dGVMuestraListaEstudiantes.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(161, 221);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(78, 22);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormMuestraEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dGVMuestraListaEstudiantes);
            this.Name = "FormMuestraEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de registro de estudiantes";
            this.Load += new System.EventHandler(this.FormMuestraEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMuestraListaEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMuestraListaEstudiantes;
        private System.Windows.Forms.Button btnCerrar;
    }
}