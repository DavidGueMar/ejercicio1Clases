
namespace ejercicio1Clases
{
    partial class ConsultaPorCodigo
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
            this.lblCodigoConsultar = new System.Windows.Forms.Label();
            this.txtCodigoConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultarCodigo = new System.Windows.Forms.Button();
            this.rbtConsultarCodigo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(235, 205);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCodigoConsultar
            // 
            this.lblCodigoConsultar.AutoSize = true;
            this.lblCodigoConsultar.Location = new System.Drawing.Point(12, 23);
            this.lblCodigoConsultar.Name = "lblCodigoConsultar";
            this.lblCodigoConsultar.Size = new System.Drawing.Size(46, 13);
            this.lblCodigoConsultar.TabIndex = 1;
            this.lblCodigoConsultar.Text = "Codigo: ";
            // 
            // txtCodigoConsultar
            // 
            this.txtCodigoConsultar.Location = new System.Drawing.Point(64, 16);
            this.txtCodigoConsultar.Name = "txtCodigoConsultar";
            this.txtCodigoConsultar.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoConsultar.TabIndex = 2;
            // 
            // btnConsultarCodigo
            // 
            this.btnConsultarCodigo.Location = new System.Drawing.Point(170, 14);
            this.btnConsultarCodigo.Name = "btnConsultarCodigo";
            this.btnConsultarCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCodigo.TabIndex = 3;
            this.btnConsultarCodigo.Text = "Consultar";
            this.btnConsultarCodigo.UseVisualStyleBackColor = true;
            this.btnConsultarCodigo.Click += new System.EventHandler(this.btnConsultarCodigo_Click);
            // 
            // rbtConsultarCodigo
            // 
            this.rbtConsultarCodigo.Location = new System.Drawing.Point(15, 42);
            this.rbtConsultarCodigo.Name = "rbtConsultarCodigo";
            this.rbtConsultarCodigo.Size = new System.Drawing.Size(219, 159);
            this.rbtConsultarCodigo.TabIndex = 4;
            this.rbtConsultarCodigo.Text = "";
            // 
            // ConsultaPorCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 240);
            this.Controls.Add(this.rbtConsultarCodigo);
            this.Controls.Add(this.btnConsultarCodigo);
            this.Controls.Add(this.txtCodigoConsultar);
            this.Controls.Add(this.lblCodigoConsultar);
            this.Controls.Add(this.btnVolver);
            this.Name = "ConsultaPorCodigo";
            this.Text = "ConsultaPorCodigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCodigoConsultar;
        private System.Windows.Forms.TextBox txtCodigoConsultar;
        private System.Windows.Forms.Button btnConsultarCodigo;
        private System.Windows.Forms.RichTextBox rbtConsultarCodigo;
    }
}