using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administrador_de_Encuestas
{
    public partial class FormPreguntas : Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DgvPreguntas.DataSource = MariaDB.ObtenerPreguntas();
        }

        private void BRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
