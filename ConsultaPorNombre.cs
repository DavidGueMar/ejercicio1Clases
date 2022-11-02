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
    public partial class ConsultaPorNombre : Form
    {
        public ConsultaPorNombre()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnConsultarNombre_Click(object sender, EventArgs e)
        {
            rtbConsultaNombre.Text = "ESE ARTICULO NO EXISTE \n\n *Prueba con otro nombre* ";

            foreach(Articulo articulo in Articulo.articulosList)
            {
                if (articulo.nombreArticulo.Equals(txtNombreConsultar.Text))
                {
                    rtbConsultaNombre.Text = "Código: "+ articulo.codigoArticulo.ToString() +
                        "\n\nNombre: " + articulo.nombreArticulo + 
                        "\n\nCategoría: " + articulo.categoriaArticulo+
                        "\n\nPrecio: " + articulo.precioArticulo+
                        "\n\nExistencias: "+ articulo.existenciasArticulo;
                }
            }
        }
    }
}
