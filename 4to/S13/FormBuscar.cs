using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_de_Encuestas
{
    public partial class FormBuscar : Form
    {
        private string Fecha = "";
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void BRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            Fecha = DtpFecha.Value.ToString("yyyy/MM/dd");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            int Id = 0;
            string Pregunta = "";

            if (TbId.Text.Length > 0) Id = Convert.ToInt32(TbId.Text);
            if (TbPregunta.Text.Length > 0) Pregunta = TbPregunta.Text;

            var datos = MariaDB.Buscar(Id, Fecha, Pregunta);
            if (datos.Count < 1) MessageBox.Show("No se ha encontrado ninguna pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else DgvPreguntas.DataSource = datos;
        }

    }
}
