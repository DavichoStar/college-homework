namespace Tarea2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CbModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbVersion = new System.Windows.Forms.ComboBox();
            this.LEnganche = new System.Windows.Forms.Label();
            this.BCotizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CbMeses = new System.Windows.Forms.ComboBox();
            this.CbEnganche = new System.Windows.Forms.ComboBox();
            this.LSigno = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.BNuevo = new System.Windows.Forms.Button();
            this.LTotalText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculadora de financiamiento";
            // 
            // CbModelo
            // 
            this.CbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbModelo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CbModelo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CbModelo.FormattingEnabled = true;
            this.CbModelo.Items.AddRange(new object[] {
            "Altima",
            "KICKS",
            "NP 300 FRONTIER",
            "SENTRA",
            "VERSA",
            "X - TRAIL"});
            this.CbModelo.Location = new System.Drawing.Point(293, 102);
            this.CbModelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbModelo.Name = "CbModelo";
            this.CbModelo.Size = new System.Drawing.Size(240, 27);
            this.CbModelo.TabIndex = 1;
            this.CbModelo.SelectedIndexChanged += new System.EventHandler(this.CbModeloSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el automóvil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(173, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Versiones";
            // 
            // CbVersion
            // 
            this.CbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVersion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CbVersion.FormattingEnabled = true;
            this.CbVersion.Location = new System.Drawing.Point(293, 142);
            this.CbVersion.Name = "CbVersion";
            this.CbVersion.Size = new System.Drawing.Size(240, 27);
            this.CbVersion.TabIndex = 2;
            this.CbVersion.SelectedIndexChanged += new System.EventHandler(this.CbVersionSelectedIndexChanged);
            // 
            // LEnganche
            // 
            this.LEnganche.AutoSize = true;
            this.LEnganche.BackColor = System.Drawing.Color.Transparent;
            this.LEnganche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LEnganche.Location = new System.Drawing.Point(38, 189);
            this.LEnganche.Name = "LEnganche";
            this.LEnganche.Size = new System.Drawing.Size(238, 24);
            this.LEnganche.TabIndex = 7;
            this.LEnganche.Text = "Porcentaje de enganche";
            // 
            // BCotizar
            // 
            this.BCotizar.BackColor = System.Drawing.Color.Transparent;
            this.BCotizar.Enabled = false;
            this.BCotizar.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.BCotizar.Location = new System.Drawing.Point(495, 309);
            this.BCotizar.Name = "BCotizar";
            this.BCotizar.Size = new System.Drawing.Size(85, 38);
            this.BCotizar.TabIndex = 9;
            this.BCotizar.Text = "Cotizar";
            this.BCotizar.UseVisualStyleBackColor = false;
            this.BCotizar.Click += new System.EventHandler(this.BCotizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(32, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Meses de financiamiento";
            // 
            // CbMeses
            // 
            this.CbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMeses.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CbMeses.FormattingEnabled = true;
            this.CbMeses.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48",
            "60",
            "72"});
            this.CbMeses.Location = new System.Drawing.Point(293, 225);
            this.CbMeses.Name = "CbMeses";
            this.CbMeses.Size = new System.Drawing.Size(240, 27);
            this.CbMeses.TabIndex = 4;
            this.CbMeses.SelectedIndexChanged += new System.EventHandler(this.CbMesesSelectedIndexChanged);
            // 
            // CbEnganche
            // 
            this.CbEnganche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEnganche.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.CbEnganche.FormattingEnabled = true;
            this.CbEnganche.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80"});
            this.CbEnganche.Location = new System.Drawing.Point(293, 186);
            this.CbEnganche.Name = "CbEnganche";
            this.CbEnganche.Size = new System.Drawing.Size(240, 27);
            this.CbEnganche.TabIndex = 3;
            this.CbEnganche.SelectedIndexChanged += new System.EventHandler(this.CbEnganche_SelectedIndexChanged);
            // 
            // LSigno
            // 
            this.LSigno.AutoSize = true;
            this.LSigno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LSigno.Location = new System.Drawing.Point(539, 189);
            this.LSigno.Name = "LSigno";
            this.LSigno.Size = new System.Drawing.Size(27, 24);
            this.LSigno.TabIndex = 13;
            this.LSigno.Text = "%";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LTotal.Location = new System.Drawing.Point(44, 315);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(57, 24);
            this.LTotal.TabIndex = 3;
            this.LTotal.Text = "Total";
            // 
            // BNuevo
            // 
            this.BNuevo.Location = new System.Drawing.Point(495, 353);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(85, 56);
            this.BNuevo.TabIndex = 15;
            this.BNuevo.Text = "Nuevo Cálculo";
            this.BNuevo.UseVisualStyleBackColor = true;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // LTotalText
            // 
            this.LTotalText.AutoSize = true;
            this.LTotalText.Font = new System.Drawing.Font("Arial", 10F);
            this.LTotalText.Location = new System.Drawing.Point(107, 315);
            this.LTotalText.Name = "LTotalText";
            this.LTotalText.Size = new System.Drawing.Size(0, 19);
            this.LTotalText.TabIndex = 16;
            // 
            // Form1
            // 
            this.AcceptButton = this.BCotizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(603, 434);
            this.Controls.Add(this.LTotalText);
            this.Controls.Add(this.BNuevo);
            this.Controls.Add(this.LSigno);
            this.Controls.Add(this.CbEnganche);
            this.Controls.Add(this.CbMeses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BCotizar);
            this.Controls.Add(this.LEnganche);
            this.Controls.Add(this.CbVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbModelo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Cálculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbVersion;
        private System.Windows.Forms.Label LEnganche;
        private System.Windows.Forms.Button BCotizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbMeses;
        private System.Windows.Forms.ComboBox CbEnganche;
        private System.Windows.Forms.Label LSigno;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Label LTotalText;
    }
}

