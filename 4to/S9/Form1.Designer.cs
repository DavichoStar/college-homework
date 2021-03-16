namespace Ejercicio3_S9
{
    partial class VuelosUNID
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VuelosUNID));
            this.LTitle = new System.Windows.Forms.Label();
            this.LOrigen = new System.Windows.Forms.Label();
            this.LDestino = new System.Windows.Forms.Label();
            this.CbOrigen = new System.Windows.Forms.ComboBox();
            this.CbDestino = new System.Windows.Forms.ComboBox();
            this.LSalida = new System.Windows.Forms.Label();
            this.DtpSalida = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LResultFecha = new System.Windows.Forms.Label();
            this.LCosto = new System.Windows.Forms.Label();
            this.BElegir = new System.Windows.Forms.Button();
            this.RbOpcion2 = new System.Windows.Forms.RadioButton();
            this.RbOpcion1 = new System.Windows.Forms.RadioButton();
            this.LMoneda = new System.Windows.Forms.Label();
            this.LResultDestino = new System.Windows.Forms.Label();
            this.LResultOrigen = new System.Windows.Forms.Label();
            this.BConsultar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            resources.ApplyResources(this.LTitle, "LTitle");
            this.LTitle.BackColor = System.Drawing.Color.Transparent;
            this.LTitle.ForeColor = System.Drawing.Color.Navy;
            this.LTitle.Name = "LTitle";
            // 
            // LOrigen
            // 
            resources.ApplyResources(this.LOrigen, "LOrigen");
            this.LOrigen.ForeColor = System.Drawing.Color.White;
            this.LOrigen.Name = "LOrigen";
            // 
            // LDestino
            // 
            resources.ApplyResources(this.LDestino, "LDestino");
            this.LDestino.ForeColor = System.Drawing.Color.White;
            this.LDestino.Name = "LDestino";
            // 
            // CbOrigen
            // 
            resources.ApplyResources(this.CbOrigen, "CbOrigen");
            this.CbOrigen.BackColor = System.Drawing.SystemColors.Window;
            this.CbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOrigen.FormattingEnabled = true;
            this.CbOrigen.Items.AddRange(new object[] {
            resources.GetString("CbOrigen.Items"),
            resources.GetString("CbOrigen.Items1"),
            resources.GetString("CbOrigen.Items2"),
            resources.GetString("CbOrigen.Items3")});
            this.CbOrigen.Name = "CbOrigen";
            this.CbOrigen.SelectedIndexChanged += new System.EventHandler(this.CbOrigen_SelectedIndexChanged);
            // 
            // CbDestino
            // 
            resources.ApplyResources(this.CbDestino, "CbDestino");
            this.CbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestino.FormattingEnabled = true;
            this.CbDestino.Items.AddRange(new object[] {
            resources.GetString("CbDestino.Items"),
            resources.GetString("CbDestino.Items1"),
            resources.GetString("CbDestino.Items2"),
            resources.GetString("CbDestino.Items3"),
            resources.GetString("CbDestino.Items4"),
            resources.GetString("CbDestino.Items5")});
            this.CbDestino.Name = "CbDestino";
            this.CbDestino.SelectedIndexChanged += new System.EventHandler(this.CbDestino_SelectedIndexChanged);
            // 
            // LSalida
            // 
            resources.ApplyResources(this.LSalida, "LSalida");
            this.LSalida.ForeColor = System.Drawing.Color.White;
            this.LSalida.Name = "LSalida";
            // 
            // DtpSalida
            // 
            resources.ApplyResources(this.DtpSalida, "DtpSalida");
            this.DtpSalida.Name = "DtpSalida";
            this.DtpSalida.ValueChanged += new System.EventHandler(this.DtpSalida_ValueChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LResultFecha);
            this.panel1.Controls.Add(this.LCosto);
            this.panel1.Controls.Add(this.BElegir);
            this.panel1.Controls.Add(this.RbOpcion2);
            this.panel1.Controls.Add(this.RbOpcion1);
            this.panel1.Controls.Add(this.LMoneda);
            this.panel1.Controls.Add(this.LResultDestino);
            this.panel1.Controls.Add(this.LResultOrigen);
            this.panel1.Name = "panel1";
            // 
            // LResultFecha
            // 
            resources.ApplyResources(this.LResultFecha, "LResultFecha");
            this.LResultFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LResultFecha.Name = "LResultFecha";
            // 
            // LCosto
            // 
            resources.ApplyResources(this.LCosto, "LCosto");
            this.LCosto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LCosto.Name = "LCosto";
            // 
            // BElegir
            // 
            resources.ApplyResources(this.BElegir, "BElegir");
            this.BElegir.BackColor = System.Drawing.Color.Gold;
            this.BElegir.ForeColor = System.Drawing.Color.Black;
            this.BElegir.Name = "BElegir";
            this.BElegir.UseVisualStyleBackColor = false;
            this.BElegir.Click += new System.EventHandler(this.BElegir_Click);
            // 
            // RbOpcion2
            // 
            resources.ApplyResources(this.RbOpcion2, "RbOpcion2");
            this.RbOpcion2.Name = "RbOpcion2";
            this.RbOpcion2.TabStop = true;
            this.RbOpcion2.UseVisualStyleBackColor = true;
            this.RbOpcion2.CheckedChanged += new System.EventHandler(this.RbOpcion2_CheckedChanged);
            // 
            // RbOpcion1
            // 
            resources.ApplyResources(this.RbOpcion1, "RbOpcion1");
            this.RbOpcion1.Name = "RbOpcion1";
            this.RbOpcion1.TabStop = true;
            this.RbOpcion1.UseVisualStyleBackColor = true;
            this.RbOpcion1.CheckedChanged += new System.EventHandler(this.RbOpcion1_CheckedChanged);
            // 
            // LMoneda
            // 
            resources.ApplyResources(this.LMoneda, "LMoneda");
            this.LMoneda.Name = "LMoneda";
            // 
            // LResultDestino
            // 
            resources.ApplyResources(this.LResultDestino, "LResultDestino");
            this.LResultDestino.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LResultDestino.Name = "LResultDestino";
            // 
            // LResultOrigen
            // 
            resources.ApplyResources(this.LResultOrigen, "LResultOrigen");
            this.LResultOrigen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LResultOrigen.Name = "LResultOrigen";
            // 
            // BConsultar
            // 
            resources.ApplyResources(this.BConsultar, "BConsultar");
            this.BConsultar.BackColor = System.Drawing.Color.Gold;
            this.BConsultar.FlatAppearance.BorderSize = 0;
            this.BConsultar.ForeColor = System.Drawing.Color.Black;
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LTitle);
            this.panel2.Name = "panel2";
            // 
            // VuelosUNID
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.BConsultar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtpSalida);
            this.Controls.Add(this.LSalida);
            this.Controls.Add(this.CbDestino);
            this.Controls.Add(this.CbOrigen);
            this.Controls.Add(this.LDestino);
            this.Controls.Add(this.LOrigen);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "VuelosUNID";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LOrigen;
        private System.Windows.Forms.Label LDestino;
        private System.Windows.Forms.ComboBox CbOrigen;
        private System.Windows.Forms.ComboBox CbDestino;
        private System.Windows.Forms.Label LSalida;
        private System.Windows.Forms.DateTimePicker DtpSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LResultFecha;
        private System.Windows.Forms.Label LCosto;
        private System.Windows.Forms.Button BElegir;
        private System.Windows.Forms.RadioButton RbOpcion2;
        private System.Windows.Forms.RadioButton RbOpcion1;
        private System.Windows.Forms.Label LMoneda;
        private System.Windows.Forms.Label LResultDestino;
        private System.Windows.Forms.Label LResultOrigen;
    }
}

