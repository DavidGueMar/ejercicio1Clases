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
    public partial class ConsultaPorCodigo : Form
    {
        public ConsultaPorCodigo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnConsultarCodigo_Click(object sender, EventArgs e)
        {
            rbtConsultarCodigo.Text = "ESE ARTICULO NO EXISTE \n\n *Prueba con otro codigo*";

            foreach (Articulo articulo in Articulo.articulosList)
            {
                if (articulo.codigoArticulo.Equals(int.Parse(txtCodigoConsultar.Text)))
                {
                    rbtConsultarCodigo.Text = "Código: " + articulo.codigoArticulo.ToString() +
                        "\n\nNombre: " + articulo.nombreArticulo +
                        "\n\nCategoría: " + articulo.categoriaArticulo +
                        "\n\nPrecio: " + articulo.precioArticulo +
                        "\n\nExistencias: " + articulo.existenciasArticulo;
                }
            }
        }
    }
}
