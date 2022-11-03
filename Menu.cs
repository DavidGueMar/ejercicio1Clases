using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1Clases
{
    public partial class Menu : Form
    {
        Articulo articulo = new Articulo();

        int contadorAltas = 0;
        public Menu()
        {
            InitializeComponent();
        }


        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAltas.Visible = true;

        }


        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPorNombre porNombre = new ConsultaPorNombre();
            porNombre.Show();
            this.Hide();
        }

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPorCodigo porCodigo = new ConsultaPorCodigo();
            porCodigo.Show();
            this.Hide();

        }


        private void Menu_Load(object sender, EventArgs e)
        {
            rtbListados.Visible = false;
            gbAltas.Visible = false;

            
           /* Articulo articulo1 = new Articulo(1, "asus", "Informatica", 569.99, 2);
            Articulo articulo2 = new Articulo(2, "hp", "Imagen", 569.99, 3);
            Articulo articulo3 = new Articulo(3, "samsung", "Telefonia", 569.99, 6);
            Articulo articulo4 = new Articulo(4, "sony", "Sonido", 569.99, 20);
            Articulo.articulosList.Add(articulo1);
            Articulo.articulosList.Add(articulo2);
            Articulo.articulosList.Add(articulo3);
            Articulo.articulosList.Add(articulo4);
           */
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbListados.Clear();
            rtbListados.Visible = true;

            foreach (Articulo a in Articulo.articulosList)
            {
                rtbListados.Text += a.ToString();


            }
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            
            contadorAltas++;

            int codigoArticulo = contadorAltas;
            string nombreArticulo = txtNombreArticulo.Text;
            string categoriaArticulo = cboxCategoriaArticulo.Text;
            double precioArticulo = double.Parse(txtPrecioArticulo.Text);
            int existenciasArticulo = int.Parse(txtExistenciasArticulo.Text);

            Articulo nuevoArticulo = new Articulo(codigoArticulo, nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo);
            Articulo.articulosList.Add(nuevoArticulo);
            MessageBox.Show("Articulo añadido");


            txtNombreArticulo.Text = "";
            cboxCategoriaArticulo.Text = "";
            txtPrecioArticulo.Text = "";
            txtExistenciasArticulo.Text = "";
            gbAltas.Visible = false;



        }
    }
}
