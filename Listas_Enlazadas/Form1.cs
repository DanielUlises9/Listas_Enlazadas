using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Enlazadas
{
    public partial class Form1 : Form
    {


        Estructura catalogo = new Estructura();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClaseBase nuevo;
            nuevo = new ClaseBase(Convert.ToInt32(txtDato.Text));
            catalogo.agregar(nuevo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = catalogo.listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            catalogo.eliminarInicio();
        }

        private void btnEliminaUltimo_Click(object sender, EventArgs e)
        {
            catalogo.eliminarUltimo();
        }

        private void btnInvLista_Click(object sender, EventArgs e)
        {
            catalogo.invertirlista();
        }

        private void btnElimninardato_Click(object sender, EventArgs e)
        {
            catalogo.Elimi(Convert.ToInt32(txtDato.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblRes.Text=Convert.ToString( catalogo.buscar (Convert.ToInt32(txtDato.Text)))+"encontrado";
        }
    }
}
