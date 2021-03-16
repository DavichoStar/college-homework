using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        int meses;
        double porcentaje;
        double precio;
        string patronNumbers = @"(?:- *)?\d+(?:\.\d+)?";
        public Form1()
        {
            InitializeComponent();
        }

        private void Comprobar()
        {
            if (CbModelo.SelectedIndex >= 0 && CbMeses.SelectedIndex >= 0 && CbVersion.SelectedIndex >= 0 && CbEnganche.SelectedIndex >= 0) BCotizar.Enabled = true;
        }

        private void CbModeloSelectedIndexChanged(object sender, EventArgs e)
        {
            int indice;
            indice = CbModelo.SelectedIndex;

            CbVersion.Items.Clear();
            switch (indice)
            {
                case 0:
                    CbVersion.Items.Add("SR $540,400");
                    CbVersion.Items.Add("ADVANCE $615,900");
                    CbVersion.Items.Add("EXCLUSIVE $693,300");
                    break;
                case 1:
                    CbVersion.Items.Add("MT SENSE $299,900");
                    CbVersion.Items.Add("CVT ADVANCE $335,034");
                    CbVersion.Items.Add("CVT EXCLUSIVE $380,009");
                    break;
                case 2:
                    CbVersion.Items.Add("XE T/M AC PAC. SEG. 6 VEL $417,900");
                    CbVersion.Items.Add("LE T/M AC 6 VEL. $466,900");
                    CbVersion.Items.Add("PLATINUM LE T/M AC 6LEV. $523,900");
                    break;
                case 3:
                    CbVersion.Items.Add("SENSE TM $317,900");
                    CbVersion.Items.Add("SENSE CVT $336,900");
                    CbVersion.Items.Add("ADVANCE TM $358,900");
                    break;
                case 4:
                    CbVersion.Items.Add("SENSE TM $258,900");
                    CbVersion.Items.Add("SENSE CVT $276,900");
                    CbVersion.Items.Add("ALVANCE TM $289,900");
                    break;
                case 5:
                    CbVersion.Items.Add("SENSE 2 ROW $465,300");
                    CbVersion.Items.Add("SENSE 3 ROW $481,500");
                    CbVersion.Items.Add("ADVANCE 2 ROW $530,800");
                    break;
                default:
                    CbVersion.Items.Add("Elija una opcion");
                    break;
            }
            Comprobar();
        }

        private void CbVersionSelectedIndexChanged(object sender, EventArgs e)
        {
            var newText = "";
            Regex regexNumbers = new Regex(patronNumbers);
            if (CbVersion.SelectedIndex >= 0)
            {
                foreach (Match m in regexNumbers.Matches(CbVersion.SelectedItem.ToString()))
                {
                    newText += m.Value;
                }
                precio = double.Parse(newText);
                Comprobar();
            }

        }

        private void CbEnganche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEnganche.SelectedIndex >= 0) porcentaje = double.Parse("0." + CbEnganche.SelectedItem.ToString());
            Comprobar();
        }

        private void CbMesesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbMeses.SelectedIndex >= 0) meses = int.Parse(CbMeses.SelectedItem.ToString());
            Comprobar();
        }

        private void BCotizar_Click(object sender, EventArgs e)
        {
            double sumInt = 0.06;

            sumInt *= meses;

            porcentaje = precio * porcentaje;
            precio -= porcentaje;
            double interes = precio * sumInt;
            double costoTotal = interes + precio;
            double mensualidad = costoTotal / meses;

            LTotalText.Text = "Mensualidades de: $" + string.Format("{0:n0}", mensualidad) + " a " + meses + " meses.\nEnganche: $" + string.Format("{0:n0}", porcentaje) + ".\nTotal a Pagar al finalizar: $" + string.Format("{0:n0}", costoTotal);

            var newText = "";
            Regex regexNumbers = new Regex(patronNumbers);
            foreach (Match m in regexNumbers.Matches(CbVersion.SelectedItem.ToString()))
            {
                newText += m.Value;
            }
            precio = double.Parse(newText);
            porcentaje = double.Parse("0." + CbEnganche.SelectedItem.ToString());
            BCotizar.Enabled = false;
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            CbModelo.SelectedIndex = -1;
            CbVersion.SelectedIndex = -1;
            CbEnganche.SelectedIndex = -1;
            CbMeses.SelectedIndex = -1;
            CbVersion.Items.Clear();
            LTotalText.Text = "";
            precio = 0;
            meses = 0;
            porcentaje = 0;
        }

    }
}