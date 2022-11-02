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

        public Menu()
        {
            InitializeComponent();
        }


        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas alta = new Altas();
            alta.Show();
            this.Hide();
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
            Articulo articulo1 = new Articulo(1, "asus", "Informatica", 569.99, 5);
            Articulo articulo2 = new Articulo(2, "hp", "Imagen", 569.99, 4);
            Articulo articulo3 = new Articulo(3, "samsung", "Telefonia", 569.99, 5);
            Articulo articulo4 = new Articulo(4, "sony", "Sonido", 569.99, 5);
            Articulo.articulosList.Add(articulo1);
            Articulo.articulosList.Add(articulo2);
            Articulo.articulosList.Add(articulo3);
            Articulo.articulosList.Add(articulo4);
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbListados.Clear();
            //gbListados.Text = articulo1.ToString();
            for (int i = 0; i < Articulo.articulosList.Count; i++)
            {
                rtbListados.Text += Articulo.articulosList[i].ToString();

            }

            /*foreach (Articulo a in Articulo.articulosList)
            {
                rtbListados.Text += a.ToString();


            }*/
        }
    }
}
