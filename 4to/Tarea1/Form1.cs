using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            var promedio = (int.Parse(TbParcial1.Text) + int.Parse(TbParcial2.Text) + int.Parse(TbParcial3.Text)) / 3;
            var resultado = TbNombre.Text + " con ID: " + TbID.Text + " sacó un promedio de: " + promedio;

            LResultado.Text = resultado;
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TbNombre.Clear();
            TbID.Clear();
            TbParcial1.Clear();
            TbParcial2.Clear();
            TbParcial3.Clear();
            LResultado.ResetText();
        }
    }
}
