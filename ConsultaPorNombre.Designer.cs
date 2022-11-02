
namespace ejercicio1Clases
{
    partial class ConsultaPorNombre
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombreConsultar = new System.Windows.Forms.Label();
            this.txtNombreConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultarNombre = new System.Windows.Forms.Button();
            this.rtbConsultaNombre = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(228, 219);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombreConsultar
            // 
            this.lblNombreConsultar.AutoSize = true;
            this.lblNombreConsultar.Location = new System.Drawing.Point(12, 39);
            this.lblNombreConsultar.Name = "lblNombreConsultar";
            this.lblNombreConsultar.Size = new System.Drawing.Size(47, 13);
            this.lblNombreConsultar.TabIndex = 1;
            this.lblNombreConsultar.Text = "Nombre:";
            // 
            // txtNombreConsultar
            // 
            this.txtNombreConsultar.Location = new System.Drawing.Point(65, 32);
            this.txtNombreConsultar.Name = "txtNombreConsultar";
            this.txtNombreConsultar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreConsultar.TabIndex = 2;
            // 
            // btnConsultarNombre
            // 
            this.btnConsultarNombre.Location = new System.Drawing.Point(171, 29);
            this.btnConsultarNombre.Name = "btnConsultarNombre";
            this.btnConsultarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarNombre.TabIndex = 3;
            this.btnConsultarNombre.Text = "Consultar";
            this.btnConsultarNombre.UseVisualStyleBackColor = true;
            this.btnConsultarNombre.Click += new System.EventHandler(this.btnConsultarNombre_Click);
            // 
            // rtbConsultaNombre
            // 
            this.rtbConsultaNombre.Location = new System.Drawing.Point(15, 58);
            this.rtbConsultaNombre.Name = "rtbConsultaNombre";
            this.rtbConsultaNombre.Size = new System.Drawing.Size(211, 158);
            this.rtbConsultaNombre.TabIndex = 4;
            this.rtbConsultaNombre.Text = "";
            // 
            // ConsultaPorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 250);
            this.Controls.Add(this.rtbConsultaNombre);
            this.Controls.Add(this.btnConsultarNombre);
            this.Controls.Add(this.txtNombreConsultar);
            this.Controls.Add(this.lblNombreConsultar);
            this.Controls.Add(this.btnVolver);
            this.Name = "ConsultaPorNombre";
            this.Text = "ConsultaPorNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombreConsultar;
        private System.Windows.Forms.TextBox txtNombreConsultar;
        private System.Windows.Forms.Button btnConsultarNombre;
        private System.Windows.Forms.RichTextBox rtbConsultaNombre;
    }
}