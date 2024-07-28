using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILAS.EJERCICIO_P6
{
    public partial class P6 : Form
    {
        pila6 pila = new pila6();
        public P6()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtValor.Text);
                txtValor.Clear();
                txtValor.Focus();
                pila.push(x);
                pila.mostrar(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void btnInsertarposicion_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtPosicion.Text);
                int n = int.Parse(txtValor.Text);

                txtValor.Clear();
                txtPosicion.Clear();
                txtValor.Focus();
                pila.insertarPilaPosicion(n, x);
                pila.mostrar(lstDatos);
            }
            catch
            {
                MessageBox.Show("Por favor, insertar un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtPosicion.Clear();
                txtValor.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            txtValor.Clear();
            txtPosicion.Clear();
            txtValor.Focus();
        }
    }
}
