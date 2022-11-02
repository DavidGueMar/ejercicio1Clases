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
    public partial class Altas : Form
    {
        public int contador = 4;
        public Altas()
        {
            InitializeComponent();
        }



        private void btnAltas_Click(object sender, EventArgs e)
        {
            contador++;
            int codigoArticulo = contador;
            string nombreArticulo = txtNombreArticulo.Text;
            string categoriaArticulo = cboxCategoriaArticulo.Text;
            double precioArticulo = double.Parse(txtPrecioArticulo.Text);
            int existenciasArticulo = int.Parse(txtExistenciasArticulo.Text);

            Articulo nuevoArticulo = new Articulo(codigoArticulo, nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo);
            Articulo.articulosList.Add(nuevoArticulo);
            MessageBox.Show("Articulo añadido");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
