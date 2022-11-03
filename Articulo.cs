using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1Clases
{
    class Articulo
    {
        public int codigoArticulo { get; set; }
        public String nombreArticulo { get; set; }
        public String categoriaArticulo { get; set; }
        public double precioArticulo { get; set; }
        public int existenciasArticulo { get; set; }


        public static List<Articulo> articulosList = new List<Articulo>();

        public Articulo(int codigoArticulo, String nombreArticulo, String categoriaArticulo, double precioArticulo, int existenciasArticulo)
        {
            this.codigoArticulo = codigoArticulo;
            this.nombreArticulo = nombreArticulo;
            this.categoriaArticulo = categoriaArticulo;
            this.precioArticulo = precioArticulo;
            this.existenciasArticulo = existenciasArticulo;

        }

        public Articulo()
        {

        }

        public void actualizarExistencias(int cantidadPedido)
        {

            double precioTotal = cantidadPedido * precioArticulo;
            if (existenciasArticulo > cantidadPedido)
            {
                MessageBox.Show("El importe del pedido es" + precioTotal);
                existenciasArticulo = existenciasArticulo - cantidadPedido;

                MessageBox.Show("Ahora quedan" + existenciasArticulo + "existencias");
            }
            else
            {
                MessageBox.Show("No hay existencias suficientes, quedan " + existenciasArticulo);
            }
        }


        //TODO esto hay que cambiarlo por el metodo ToString() y sobrescribirlo 
       /*public void imprimirArticulo()
        {
            MessageBox.Show("Codigo del articulo: " + codigoArticulo.ToString() +
                "\nNombre del articulo: " + nombreArticulo +
                "\nCategoria del articulo: " + categoriaArticulo +
                "\nPrecio del articulo: " + precioArticulo.ToString() +
                "\nExistencias del articulo: " + existenciasArticulo.ToString());
        }*/


        public override string ToString()
        {
            String texto = "   *Codigo del articulo*: " + codigoArticulo +
                "\n\nNombre del articulo: " + nombreArticulo +
                "\n\nCategoria del articulo: " + categoriaArticulo +
                "\n\nPrecio del articulo: " + precioArticulo +
                "\n\nExistencias del articulo: " + existenciasArticulo+
                "\n-------------------------------------------------------\n";
            return texto;
        }
    }
}
