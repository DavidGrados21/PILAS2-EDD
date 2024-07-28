using PILAS.EJERCICIO_P1;
using PILAS.EJERCICIO_P2;
using PILAS.EJERCICIO_P3;
using PILAS.EJERCICIO_P4;
using PILAS.EJERCICIO_P5;
using PILAS.EJERCICIO_P6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los integrantes son\n" +
    "\n- ARNOLD EMILIO CHOMBA SUAREZ" +
    "\n- DEYBY MAURICIO GRADOS SHUPINGAHUA" +
    "\n- KATHERINE LISBETH LLACCOLLA GAMBOA" +
    "\n- LAURA THALIA GARCIA LUJAN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            Form ventana = new P1();
            ventana.Show();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            Form ventana = new P2();
            ventana.Show();
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            Form ventana = new P3();
            ventana.Show();
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            Form ventana = new P4();
            ventana.Show();
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            Form ventana = new P5();
            ventana.Show();
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
            Form ventana = new P6();
            ventana.Show();
        }
    }
}
