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
    public partial class FormCrearP : Form
    {
        public FormCrearP()
        {
            InitializeComponent();
            MariaDB.ObtenerConexion();
            DtpInicio.Value = DateTime.Now;
            DtpFin.Value = DateTime.Now.AddDays(1);
        }

        private void BEncuestas_Click(object sender, EventArgs e)
        {
            FormPreguntas FEncuentas = new FormPreguntas
            {
                Icon = this.Icon,
                Text = this.LTitle.Text,
                DesktopLocation = this.DesktopLocation
            };
            FEncuentas.Show();
            this.Visible = false;
            FEncuentas.FormClosed += FEncuentas_FormClosed;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar FBuscar = new FormBuscar
            {
                Icon = this.Icon,
                Text = this.LTitle.Text,
                DesktopLocation = this.DesktopLocation
            };
            FBuscar.Show();
            this.Visible = false;
            FBuscar.FormClosed += FEncuentas_FormClosed;
        }

        private void FEncuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            Encuesta pEncuesta = new Encuesta
            { 
                FInicio = DtpInicio.Value.ToString("yyyy/MM/dd"),
                FFin = DtpFin.Value.ToString("yyyy/MM/dd"),
                Pregunta = TbPregunta.Text,
            };

            int resultado = MariaDB.AgregarPregunta(pEncuesta);

            if (resultado > 0) MessageBox.Show("¡Pregunta Agregada A La Encuesta Con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("No se pudo guardar la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TbPregunta_TextChanged(object sender, EventArgs e)
        {
            if (TbPregunta.TextLength > 4) BEnviar.Enabled = true;
            else BEnviar.Enabled = false;
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TbPregunta.Text = "";
            DtpInicio.Value = DateTime.Now;
            DtpFin.Value = DateTime.Now.AddDays(1);
        }
    }
}
