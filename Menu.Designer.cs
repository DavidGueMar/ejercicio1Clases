
namespace ejercicio1Clases
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rtbListados = new System.Windows.Forms.RichTextBox();
            this.gbAltas = new System.Windows.Forms.GroupBox();
            this.btnAltas = new System.Windows.Forms.Button();
            this.cboxCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.txtExistenciasArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.lblExistenciasArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbAltas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porCodigoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCodigoToolStripMenuItem.Text = "Por codigo";
            this.porCodigoToolStripMenuItem.Click += new System.EventHandler(this.porCodigoToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.minimosToolStripMenuItem,
            this.categoríaToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // minimosToolStripMenuItem
            // 
            this.minimosToolStripMenuItem.Name = "minimosToolStripMenuItem";
            this.minimosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimosToolStripMenuItem.Text = "Minimos ";
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtbListados
            // 
            this.rtbListados.Location = new System.Drawing.Point(12, 36);
            this.rtbListados.Name = "rtbListados";
            this.rtbListados.Size = new System.Drawing.Size(208, 291);
            this.rtbListados.TabIndex = 1;
            this.rtbListados.Text = "";
            // 
            // gbAltas
            // 
            this.gbAltas.Controls.Add(this.btnAltas);
            this.gbAltas.Controls.Add(this.cboxCategoriaArticulo);
            this.gbAltas.Controls.Add(this.txtExistenciasArticulo);
            this.gbAltas.Controls.Add(this.txtPrecioArticulo);
            this.gbAltas.Controls.Add(this.txtNombreArticulo);
            this.gbAltas.Controls.Add(this.lblExistenciasArticulo);
            this.gbAltas.Controls.Add(this.lblPrecioArticulo);
            this.gbAltas.Controls.Add(this.lblCategoriaArticulo);
            this.gbAltas.Controls.Add(this.lblNombreArticulo);
            this.gbAltas.Location = new System.Drawing.Point(226, 36);
            this.gbAltas.Name = "gbAltas";
            this.gbAltas.Size = new System.Drawing.Size(205, 208);
            this.gbAltas.TabIndex = 2;
            this.gbAltas.TabStop = false;
            this.gbAltas.Text = "Altas";
            // 
            // btnAltas
            // 
            this.btnAltas.Location = new System.Drawing.Point(69, 163);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(75, 23);
            this.btnAltas.TabIndex = 18;
            this.btnAltas.Text = "Aceptar";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // cboxCategoriaArticulo
            // 
            this.cboxCategoriaArticulo.FormattingEnabled = true;
            this.cboxCategoriaArticulo.Items.AddRange(new object[] {
            "Informatica",
            "Imagen",
            "Telefonia",
            "Sonido"});
            this.cboxCategoriaArticulo.Location = new System.Drawing.Point(69, 53);
            this.cboxCategoriaArticulo.Name = "cboxCategoriaArticulo";
            this.cboxCategoriaArticulo.Size = new System.Drawing.Size(121, 21);
            this.cboxCategoriaArticulo.TabIndex = 17;
            // 
            // txtExistenciasArticulo
            // 
            this.txtExistenciasArticulo.Location = new System.Drawing.Point(69, 119);
            this.txtExistenciasArticulo.Name = "txtExistenciasArticulo";
            this.txtExistenciasArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtExistenciasArticulo.TabIndex = 16;
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(69, 87);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioArticulo.TabIndex = 15;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(69, 24);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtNombreArticulo.TabIndex = 14;
            // 
            // lblExistenciasArticulo
            // 
            this.lblExistenciasArticulo.AutoSize = true;
            this.lblExistenciasArticulo.Location = new System.Drawing.Point(6, 126);
            this.lblExistenciasArticulo.Name = "lblExistenciasArticulo";
            this.lblExistenciasArticulo.Size = new System.Drawing.Size(63, 13);
            this.lblExistenciasArticulo.TabIndex = 13;
            this.lblExistenciasArticulo.Text = "Existencias:";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(6, 94);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArticulo.TabIndex = 12;
            this.lblPrecioArticulo.Text = "Precio:";
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(6, 61);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaArticulo.TabIndex = 11;
            this.lblCategoriaArticulo.Text = "Categoria:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(6, 31);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArticulo.TabIndex = 10;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(497, 434);
            this.Controls.Add(this.gbAltas);
            this.Controls.Add(this.rtbListados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAltas.ResumeLayout(false);
            this.gbAltas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rtbListados;
        private System.Windows.Forms.GroupBox gbAltas;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.ComboBox cboxCategoriaArticulo;
        private System.Windows.Forms.TextBox txtExistenciasArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label lblExistenciasArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
    }
}

