namespace Administrador_de_Encuestas
{
    partial class FormCrearP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearP));
            this.LTitle = new System.Windows.Forms.Label();
            this.LInstrucciones = new System.Windows.Forms.Label();
            this.LPregunta = new System.Windows.Forms.Label();
            this.LFechaFin = new System.Windows.Forms.Label();
            this.LFechaInicio = new System.Windows.Forms.Label();
            this.BEnviar = new System.Windows.Forms.Button();
            this.TbPregunta = new System.Windows.Forms.TextBox();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BEncuestas = new System.Windows.Forms.Button();
            this.LEjemplo = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.ForeColor = System.Drawing.Color.Gold;
            this.LTitle.Location = new System.Drawing.Point(190, 47);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(353, 29);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Administrador de Encuenstas";
            // 
            // LInstrucciones
            // 
            this.LInstrucciones.AutoSize = true;
            this.LInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInstrucciones.Location = new System.Drawing.Point(36, 140);
            this.LInstrucciones.Name = "LInstrucciones";
            this.LInstrucciones.Size = new System.Drawing.Size(377, 25);
            this.LInstrucciones.TabIndex = 1;
            this.LInstrucciones.Text = "Introduce los datos de la nueva encuestas";
            // 
            // LPregunta
            // 
            this.LPregunta.AutoSize = true;
            this.LPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPregunta.Location = new System.Drawing.Point(35, 198);
            this.LPregunta.Name = "LPregunta";
            this.LPregunta.Size = new System.Drawing.Size(97, 25);
            this.LPregunta.TabIndex = 2;
            this.LPregunta.Text = "Pregunta:";
            // 
            // LFechaFin
            // 
            this.LFechaFin.AutoSize = true;
            this.LFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaFin.Location = new System.Drawing.Point(382, 281);
            this.LFechaFin.Name = "LFechaFin";
            this.LFechaFin.Size = new System.Drawing.Size(132, 25);
            this.LFechaFin.TabIndex = 3;
            this.LFechaFin.Text = "Fecha de Fin:";
            // 
            // LFechaInicio
            // 
            this.LFechaInicio.AutoSize = true;
            this.LFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaInicio.Location = new System.Drawing.Point(35, 282);
            this.LFechaInicio.Name = "LFechaInicio";
            this.LFechaInicio.Size = new System.Drawing.Size(150, 25);
            this.LFechaInicio.TabIndex = 4;
            this.LFechaInicio.Text = "Fecha de Inicio:";
            // 
            // BEnviar
            // 
            this.BEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BEnviar.BackColor = System.Drawing.Color.Gold;
            this.BEnviar.Enabled = false;
            this.BEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEnviar.Location = new System.Drawing.Point(229, 26);
            this.BEnviar.Name = "BEnviar";
            this.BEnviar.Size = new System.Drawing.Size(115, 40);
            this.BEnviar.TabIndex = 5;
            this.BEnviar.Text = "Enviar";
            this.BEnviar.UseVisualStyleBackColor = false;
            this.BEnviar.Click += new System.EventHandler(this.BEnviar_Click);
            // 
            // TbPregunta
            // 
            this.TbPregunta.Location = new System.Drawing.Point(151, 201);
            this.TbPregunta.Name = "TbPregunta";
            this.TbPregunta.Size = new System.Drawing.Size(528, 22);
            this.TbPregunta.TabIndex = 1;
            this.TbPregunta.TextChanged += new System.EventHandler(this.TbPregunta_TextChanged);
            // 
            // DtpInicio
            // 
            this.DtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(196, 282);
            this.DtpInicio.MinDate = new System.DateTime(2020, 12, 4, 0, 0, 0, 0);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(136, 26);
            this.DtpInicio.TabIndex = 2;
            // 
            // DtpFin
            // 
            this.DtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(543, 281);
            this.DtpFin.MinDate = new System.DateTime(2020, 12, 4, 0, 0, 0, 0);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpFin.Size = new System.Drawing.Size(136, 26);
            this.DtpFin.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 118);
            this.panel1.TabIndex = 10;
            // 
            // BLimpiar
            // 
            this.BLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BLimpiar.BackColor = System.Drawing.Color.White;
            this.BLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(41, 26);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(108, 40);
            this.BLimpiar.TabIndex = 4;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.BBuscar);
            this.panel2.Controls.Add(this.BEncuestas);
            this.panel2.Controls.Add(this.BLimpiar);
            this.panel2.Controls.Add(this.BEnviar);
            this.panel2.Location = new System.Drawing.Point(-8, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 104);
            this.panel2.TabIndex = 12;
            // 
            // BEncuestas
            // 
            this.BEncuestas.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BEncuestas.BackColor = System.Drawing.Color.Gold;
            this.BEncuestas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEncuestas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BEncuestas.Location = new System.Drawing.Point(587, 18);
            this.BEncuestas.Name = "BEncuestas";
            this.BEncuestas.Size = new System.Drawing.Size(112, 57);
            this.BEncuestas.TabIndex = 6;
            this.BEncuestas.Text = "Ver Encuestas";
            this.BEncuestas.UseVisualStyleBackColor = false;
            this.BEncuestas.Click += new System.EventHandler(this.BEncuestas_Click);
            // 
            // LEjemplo
            // 
            this.LEjemplo.AutoSize = true;
            this.LEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEjemplo.Location = new System.Drawing.Point(147, 226);
            this.LEjemplo.Name = "LEjemplo";
            this.LEjemplo.Size = new System.Drawing.Size(316, 20);
            this.LEjemplo.TabIndex = 13;
            this.LEjemplo.Text = "Ejemplo: ¿Cuál es tu navegador favorito?";
            // 
            // BBuscar
            // 
            this.BBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BBuscar.BackColor = System.Drawing.Color.White;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BBuscar.Location = new System.Drawing.Point(395, 26);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(112, 40);
            this.BBuscar.TabIndex = 7;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // FormCrearP
            // 
            this.AcceptButton = this.BEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BLimpiar;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.LEjemplo);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.TbPregunta);
            this.Controls.Add(this.LFechaInicio);
            this.Controls.Add(this.LFechaFin);
            this.Controls.Add(this.LPregunta);
            this.Controls.Add(this.LInstrucciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCrearP";
            this.Text = "Administrador de Encuenstas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LInstrucciones;
        private System.Windows.Forms.Label LPregunta;
        private System.Windows.Forms.Label LFechaFin;
        private System.Windows.Forms.Label LFechaInicio;
        private System.Windows.Forms.Button BEnviar;
        private System.Windows.Forms.TextBox TbPregunta;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BEncuestas;
        private System.Windows.Forms.Label LEjemplo;
        private System.Windows.Forms.Button BBuscar;
    }
}

