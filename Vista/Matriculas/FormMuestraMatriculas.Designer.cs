
namespace PracticaLaboratorio2.Vista.Matriculas
{
    partial class FormMuestraMatriculas
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridViewMuestraMatriculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuestraMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(211, 227);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 23);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridViewMuestraMatriculas
            // 
            this.dataGridViewMuestraMatriculas.AllowDrop = true;
            this.dataGridViewMuestraMatriculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMuestraMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuestraMatriculas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMuestraMatriculas.Name = "dataGridViewMuestraMatriculas";
            this.dataGridViewMuestraMatriculas.ReadOnly = true;
            this.dataGridViewMuestraMatriculas.Size = new System.Drawing.Size(467, 197);
            this.dataGridViewMuestraMatriculas.TabIndex = 29;
            // 
            // FormMuestraMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 262);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridViewMuestraMatriculas);
            this.Name = "FormMuestraMatriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMuestraMatriculas";
            this.Load += new System.EventHandler(this.FormMuestraMatriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuestraMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridViewMuestraMatriculas;
    }
}