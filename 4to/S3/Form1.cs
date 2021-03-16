using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            var nombre = TbNombre.Text;
            var apellido = TbApellido.Text;
            int edad = int.Parse(TbEdad.Text);


            LTextInfo.Text = nombre + @" " + apellido + @" " + edad.ToString();
        }

    }
}
