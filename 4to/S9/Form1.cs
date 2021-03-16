using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_S9
{
    public partial class VuelosUNID : Form
    {
        public VuelosUNID() {
            InitializeComponent();
        }

        private void CbOrigen_SelectedIndexChanged(object sender, EventArgs e) {
            Verificar();
        }

        private void CbDestino_SelectedIndexChanged(object sender, EventArgs e) {
            Verificar();
        }

        private void DtpSalida_ValueChanged(object sender, EventArgs e) {
            Verificar();
        }

        private void Verificar() {
            if (CbOrigen.SelectedIndex >= 0 && CbDestino.SelectedIndex >= 0) BConsultar.Enabled = true;
            if ((RbOpcion1.Checked || RbOpcion2.Checked) && BConsultar.Enabled) BElegir.Enabled = true;
        }

        private void BConsultar_Click(object sender, EventArgs e) {
            LResultOrigen.Text = "Origen: " + CbOrigen.SelectedItem.ToString();
            LResultDestino.Text = "Destino: " + CbDestino.SelectedItem.ToString();
            LResultFecha.Text = "Fecha: " + DtpSalida.Value.ToShortDateString();

            var caso = int.Parse(CbOrigen.SelectedIndex.ToString() + CbDestino.SelectedIndex.ToString());
            var costo = 0;
            switch (caso) {
                case 01: // CDMX => CD Juárez
                    costo = 1190;
                    break;
                case 02: // CDMX => MTY
                    costo = 780;
                    break;
                case 03: // CDMX => VRZ
                    costo = 770;
                    break;
                case 04: // CDMX => BCN
                    costo = 12850;
                    break;
                case 05: // CDMX => NY
                    costo = 4393;
                    break;
                case 10: // CD Juárez => CDMX
                    costo = 739;
                    break;
                case 12: // CD Juárez => MTY
                    costo = 889;
                    break;
                case 13: // CD Juárez => VRZ
                    costo = 1427;
                    break;
                case 14: // CD Juárez => BCN
                    costo = 13494;
                    break;
                case 15: // CD Juárez => NY
                    costo = 4167;
                    break;
                case 20: // MTY => CDMX
                    costo = 619;
                    break;
                case 21: // MTY => CD Juárez
                    costo = 835;
                    break;
                case 23: // MTY => VRZ
                    costo = 720;
                    break;
                case 24: // MTY => BCN
                    costo = 13177;
                    break;
                case 25: // MTY => NY
                    costo = 3786;
                    break;
                case 30: // VRZ => CDMX
                    costo = 749;
                    break;
                case 31: // VRZ => CD Juárez
                    costo = 1693;
                    break;
                case 32: // VRZ => MTY
                    costo = 758;
                    break;
                case 34: // VRZ => BCN
                    costo = 13202;
                    break;
                case 35: // VRZ => NY
                    costo = 6111;
                    break;
                default:
                    break;
            }

            if (costo > 0) {


                LCosto.Text = string.Format("{0:n0}", costo);
            }
        }

        private void RbOpcion1_CheckedChanged(object sender, EventArgs e) {
            Verificar();
        }

        private void RbOpcion2_CheckedChanged(object sender, EventArgs e) {
            Verificar();
        }

        private void BElegir_Click(object sender, EventArgs e) {
            var hora = RbOpcion1.Checked ? RbOpcion1.Text : RbOpcion2.Text;
            if (!LResultFecha.Text.EndsWith("m")) LResultFecha.Text += " " + hora;
        }
    }
}
