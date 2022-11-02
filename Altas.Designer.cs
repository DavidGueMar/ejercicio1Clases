
namespace ejercicio1Clases
{
    partial class Altas
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
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblExistenciasArticulo = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtExistenciasArticulo = new System.Windows.Forms.TextBox();
            this.cboxCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(21, 60);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArticulo.TabIndex = 0;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(21, 90);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaArticulo.TabIndex = 1;
            this.lblCategoriaArticulo.Text = "Categoria:";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(21, 123);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArticulo.TabIndex = 2;
            this.lblPrecioArticulo.Text = "Precio:";
            // 
            // lblExistenciasArticulo
            // 
            this.lblExistenciasArticulo.AutoSize = true;
            this.lblExistenciasArticulo.Location = new System.Drawing.Point(21, 155);
            this.lblExistenciasArticulo.Name = "lblExistenciasArticulo";
            this.lblExistenciasArticulo.Size = new System.Drawing.Size(63, 13);
            this.lblExistenciasArticulo.TabIndex = 3;
            this.lblExistenciasArticulo.Text = "Existencias:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(84, 53);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtNombreArticulo.TabIndex = 4;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(84, 116);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioArticulo.TabIndex = 6;
            // 
            // txtExistenciasArticulo
            // 
            this.txtExistenciasArticulo.Location = new System.Drawing.Point(84, 148);
            this.txtExistenciasArticulo.Name = "txtExistenciasArticulo";
            this.txtExistenciasArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtExistenciasArticulo.TabIndex = 7;
            // 
            // cboxCategoriaArticulo
            // 
            this.cboxCategoriaArticulo.FormattingEnabled = true;
            this.cboxCategoriaArticulo.Items.AddRange(new object[] {
            "Informatica",
            "Imagen",
            "Telefonia",
            "Sonido"});
            this.cboxCategoriaArticulo.Location = new System.Drawing.Point(84, 82);
            this.cboxCategoriaArticulo.Name = "cboxCategoriaArticulo";
            this.cboxCategoriaArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboxCategoriaArticulo.TabIndex = 8;
            // 
            // btnAltas
            // 
            this.btnAltas.Location = new System.Drawing.Point(109, 192);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(75, 23);
            this.btnAltas.TabIndex = 9;
            this.btnAltas.Text = "Aceptar";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(215, 250);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 285);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.cboxCategoriaArticulo);
            this.Controls.Add(this.txtExistenciasArticulo);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.lblExistenciasArticulo);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Name = "Altas";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblExistenciasArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.TextBox txtExistenciasArticulo;
        private System.Windows.Forms.ComboBox cboxCategoriaArticulo;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnVolver;
    }
}